namespace MARDEK.UI
{
    public class CharacterEquipmentUI : InventoryCharacterUI
    {
        private void OnEnable()
        {
            AssignInventoryToUI(character.EquippedItems);
        }
    }
}