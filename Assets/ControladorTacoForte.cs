using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControladorTacoForte : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private Transform bolaTransform;
    private Rigidbody bolaRigidbody;

    public float forcaDeImpulso = 500f;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onFirstHoverEntered.AddListener(OnHoverEnter);
        grabInteractable.onLastHoverExited.AddListener(OnHoverExit);

        // Certifique-se de que a bola tem um Rigidbody para aplicar força
        bolaRigidbody = bolaTransform.GetComponent<Rigidbody>();
    }

    void OnHoverEnter(XRBaseInteractor interactor)
    {
        bolaTransform = interactor.selectTarget.transform;
    }

    void OnHoverExit(XRBaseInteractor interactor)
    {
        bolaTransform = null;
    }

    void Update()
    {
        if (grabInteractable.isSelected && bolaTransform != null)
        {
            // Calcula a direção entre a bola e o taco
            Vector3 direcao = bolaTransform.position - transform.position;

            // Normaliza a direção para obter um vetor unitário
            direcao.Normalize();

            // Aplica uma força à bola na direção oposta ao taco
            bolaRigidbody.AddForce(-direcao * forcaDeImpulso);
        }
    }
}
