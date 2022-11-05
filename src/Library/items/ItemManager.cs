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
        public void AddItem(IItem item){

            items.Add(item);            
        }

        public void ModifyCategory(int idModificar, IItem item){
            
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].id == idModificar){
                    items[i] = item;
                }
            }
        }

        public void DeleteCategory(int idModificar){

            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].id == idModificar){
                    items.RemoveAt(i);
                }
            }

        } 
}
}