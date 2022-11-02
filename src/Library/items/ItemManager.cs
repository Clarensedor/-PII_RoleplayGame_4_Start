using System.Collections.Generic;

namespace RoleplayGame
{
    

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemManager
    {
public List<IItem> items;
 
        public ItemManager(){

            this.items = new List<IItem>();
        }

       /* /// <summary>
        /// instancia para cumplir singleton 
        /// </summary>
        private static CategoriesManager _instance;

        /// <summary>
        /// Metodo para clear singleton
        /// </summary>
        /// <returns></returns>
        public static CategoriesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CategoriesManager();
            }
            return _instance;
        }
*/
        public void AddItem(IItem cat){

            items.Add(cat);            
        }

        public void ModifyCategory(int idModificar, Categorie cat){
            
            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].id == idModificar){
                    cat.servicesInCategory = categories[i].servicesInCategory;
                    categories[i] = cat;
                }
            }
        }

        public void DeleteCategory(int idModificar){

            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].id == idModificar){
                    categories.RemoveAt(i);
                }
            }

        } 
}