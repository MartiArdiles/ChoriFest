using DAOLibrary;
using entity_library.Fest;
using entity_library.Fest.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transversal_library.DTOs.Fest;
using transversal_library.Interfaces.ChoriFest.ChoriFest;


namespace services_library.Fest.ChoriFest
{
    public class ChorifestService : IChorifestService
    {
        public async Task<IEnumerable<entity_library.Fest.Chorifest>> GetChorifestList()
        {
            using (DAOFactory df = new DAOFactory())
            {
                return await df.DAOChorifest.GetListChorifest();

            }
        }
        public async Task Save(ChoriFestDTO chorifestDTO)
        {
            var chori = new Chorifest();
            var MenuChori = new MenuChorifest();


            chori.Date = chorifestDTO.Date;
            chori.Description = chorifestDTO.Description;
            chori.RegistrationStart = chorifestDTO.RegistrationStart;
            chori.RegistrationEnd = chorifestDTO.RegistrationEnd;
            chori.Title = chorifestDTO.Title;
            chori.StateChorifest = 1;
            var menuchori = new MenuChorifest();
            var menuchori2 = new MenuChorifest();

            //chori.menus.Add(menuchori);
            //chori.menus.Add(menuchori2);


            using (DAOFactory df= new DAOFactory())
            {
                
                await df.DAOChorifest.SaveChorifest(chori);
                
                foreach (var menu in chorifestDTO.menus)
                {
                   
                    await df.DaoMenu.SaveMenuChoriFest(menu);


                }
                    
                

            }

        }
    }
}
