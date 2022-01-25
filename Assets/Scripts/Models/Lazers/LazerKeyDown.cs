using UnityEngine;

namespace Models.Lazers
{
    public class LazerKeyDown: MonoBehaviour
    {
        public LazerDoorController LazerDoorController;
        
        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(TagsEnum.Character.ToString()))
            {
                LazerDoorController.TurnOn();
            }
            
            if (other.gameObject.CompareTag(TagsEnum.Box.ToString()))
            {
                LazerDoorController.TurnOn();
            }
        }
    }
}