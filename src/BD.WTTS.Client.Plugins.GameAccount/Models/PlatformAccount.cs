using System.Linq;

namespace BD.WTTS.Models;

public sealed partial class PlatformAccount
{
    readonly IPlatformSwitcher platformSwitcher;

    public PlatformAccount(ThirdpartyPlatform platform)
    {
        var platformSwitchers = Ioc.Get<IEnumerable<IPlatformSwitcher>>();
        this.Platform = platform;
        this.platformSwitcher = Platform switch
        {
            ThirdpartyPlatform.Steam => platformSwitchers.OfType<SteamPlatformSwitcher>().First(),
            _ => platformSwitchers.OfType<BasicPlatformSwitcher>().First(),
        };

        LoadUsers();
    }

    public async void LoadUsers()
    {
        var users = await platformSwitcher.GetUsers();
        if (users.Any_Nullable())
            this.Accounts = new ObservableCollection<IAccount>(users);
    }

    public bool CurrnetUserAdd(string name)
    {
        return platformSwitcher.CurrnetUserAdd(name);
    }
}
