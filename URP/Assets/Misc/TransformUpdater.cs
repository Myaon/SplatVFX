using UnityEngine;
using UnityEngine.UI;

public class TransformUpdater : MonoBehaviour
{
    public InputField posXInput;
    public InputField posYInput;
    public InputField posZInput;
    public InputField rotXInput;
    public InputField rotYInput;
    public InputField rotZInput;
    public InputField scaleInput;

    public Transform targetObject; // 対象のGameObjectのTransform

    void Start()
    {
        // InputFieldの変更時にメソッドを呼び出す設定
        posXInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        posYInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        posZInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        rotXInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        rotYInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        rotZInput.onValueChanged.AddListener(UpdateTransformFromGUI);
        scaleInput.onValueChanged.AddListener(UpdateTransformFromGUI);
    }

    void UpdateTransformFromGUI(string value)
    {
        // InputFieldの値を取得して、floatに変換
        float posX = float.Parse(posXInput.text);
        float posY = float.Parse(posYInput.text);
        float posZ = float.Parse(posZInput.text);
        float rotX = float.Parse(rotXInput.text);
        float rotY = float.Parse(rotYInput.text);
        float rotZ = float.Parse(rotZInput.text);
        float scale = float.Parse(scaleInput.text);

        // 対象のGameObjectのTransformを更新
        targetObject.position = new Vector3(posX, posY, posZ);
        targetObject.eulerAngles = new Vector3(rotX, rotY, rotZ);
        targetObject.localScale = new Vector3(scale, scale, scale);
    }
}
