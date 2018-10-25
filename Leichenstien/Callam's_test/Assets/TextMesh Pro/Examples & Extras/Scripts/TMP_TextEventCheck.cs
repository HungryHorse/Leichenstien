using UnityEngine;


namespace TMPro.Examples
{
    public class TMP_TextEventCheck : MonoBehaviour
    {

        public TMP_TextEventHandler TextEventHandler;
        TextEngine engine;

        void OnEnable()
        {
            engine = gameObject.GetComponent<TextEngine>();
            if (TextEventHandler != null)
            {
                TextEventHandler.onLinkSelection.AddListener(OnLinkSelection);
            }
        }


        void OnDisable()
        {
            if (TextEventHandler != null)
            {
                TextEventHandler.onLinkSelection.RemoveListener(OnLinkSelection);
            }
        }
        

        void OnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            engine.lastHoveredLink = linkID;
        }

    }
}