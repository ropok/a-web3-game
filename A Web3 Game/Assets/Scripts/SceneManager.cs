using Thirdweb;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private string contractAddress = "{{0x8f60403B685DcaD0ED3BB0126eBF1512b5c4BfdA}}";



    //var sdk = ThirdWebManager.Instance.SDK;
    //ThirdWebSDK sdk = ThirdWebManager.Instance.SDK;
    // Start is called before the first frame update
    async void Start()
    {
        //var sdk = ThirdwebManager.Instance.SDK;

        //var contractAddress = "{{0x8f60403B685DcaD0ED3BB0126eBF1512b5c4BfdA}}";
        //Contract contract = sdk.GetContract(contractAddress);
        //var data = await contract.ERC721.Balance();
        //Debug.Log($"Balance: {data}");
        //ConnectWallet();


    }

    void Update()
    {

    }

    public async void ConnectWallet()
    {
        var sdk = ThirdwebManager.Instance.SDK;
        var connection = new WalletConnection(
            provider: WalletProvider.Metamask,
            chainId: 11155111
            );

        string address = await sdk.wallet.Connect(connection);
        Debug.Log($"address: {address}");
    }

    public async void GetBalance()
    {
        var sdk = ThirdwebManager.Instance.SDK;
        var data = await sdk.wallet.GetBalance();
        Debug.Log($"Balance: {data}");


    }

    public void TestLog()
    {
        Debug.Log("TestLog");
    }
}
