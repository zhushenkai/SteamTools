#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable SA1634 // File header should show copyright
// <console-tools-generated/>
#pragma warning restore SA1634 // File header should show copyright
#pragma warning restore IDE0079 // 请删除不必要的忽略
// ReSharper disable once CheckNamespace
namespace BD.WTTS.Settings.Abstractions;

public interface IProxySettings
{
    static IProxySettings? Instance
        => Ioc.Get_Nullable<IOptionsMonitor<IProxySettings>>()?.CurrentValue;

    /// <summary>
    /// 启用脚本自动检查更新
    /// </summary>
    bool? IsAutoCheckScriptUpdate { get; set; }

    /// <summary>
    /// 启用脚本自动检查更新的默认值
    /// </summary>
    const bool DefaultIsAutoCheckScriptUpdate = true;

    /// <summary>
    /// 启用代理脚本
    /// </summary>
    bool? IsEnableScript { get; set; }

    /// <summary>
    /// 启用代理脚本的默认值
    /// </summary>
    const bool DefaultIsEnableScript = false;

    /// <summary>
    /// 代理服务启用状态
    /// </summary>
    IReadOnlyCollection<string>? SupportProxyServicesStatus { get; set; }

    /// <summary>
    /// 代理服务启用状态的默认值
    /// </summary>
    static readonly IReadOnlyCollection<string> DefaultSupportProxyServicesStatus = Array.Empty<string>();

    /// <summary>
    /// 脚本启用状态
    /// </summary>
    IReadOnlyCollection<int>? ScriptsStatus { get; set; }

    /// <summary>
    /// 脚本启用状态的默认值
    /// </summary>
    static readonly IReadOnlyCollection<int> DefaultScriptsStatus = Array.Empty<int>();

    #region 代理设置

    /// <summary>
    /// 程序启动时自动启动代理
    /// </summary>
    bool? ProgramStartupRunProxy { get; set; }

    /// <summary>
    /// 程序启动时自动启动代理的默认值
    /// </summary>
    const bool DefaultProgramStartupRunProxy = false;

    /// <summary>
    /// 系统代理模式端口
    /// </summary>
    int? SystemProxyPortId { get; set; }

    /// <summary>
    /// 系统代理模式端口的默认值
    /// </summary>
    const int DefaultSystemProxyPortId = 26561;

    /// <summary>
    /// 系统代理模式IP
    /// </summary>
    string? SystemProxyIp { get; set; }

    /// <summary>
    /// 系统代理模式IP的默认值
    /// </summary>
    static readonly string DefaultSystemProxyIp = IPAddress.Any.ToString();

    /// <summary>
    /// 开启加速后仅代理脚本而不加速
    /// </summary>
    bool? OnlyEnableProxyScript { get; set; }

    /// <summary>
    /// 开启加速后仅代理脚本而不加速的默认值
    /// </summary>
    const bool DefaultOnlyEnableProxyScript = false;

    /// <summary>
    /// 代理时使用的解析主DNS
    /// </summary>
    string? ProxyMasterDns { get; set; }

    /// <summary>
    /// 代理时使用的解析主DNS的默认值
    /// </summary>
    const string DefaultProxyMasterDns = "223.5.5.5";

    /// <summary>
    /// 启用 Http 链接转发到 Https
    /// </summary>
    bool? EnableHttpProxyToHttps { get; set; }

    /// <summary>
    /// 启用 Http 链接转发到 Https的默认值
    /// </summary>
    const bool DefaultEnableHttpProxyToHttps = true;

    #endregion

    #region 本地代理设置

    /// <summary>
    /// Socks5 Enable
    /// </summary>
    bool? Socks5ProxyEnable { get; set; }

    /// <summary>
    /// Socks5 Enable的默认值
    /// </summary>
    const bool DefaultSocks5ProxyEnable = false;

    /// <summary>
    /// Socks5 监听端口
    /// </summary>
    int? Socks5ProxyPortId { get; set; }

    /// <summary>
    /// Socks5 监听端口的默认值
    /// </summary>
    const int DefaultSocks5ProxyPortId = 8868;

    #endregion

    #region 二级代理设置

    /// <summary>
    /// TwoLevelAgent Enable
    /// </summary>
    bool? TwoLevelAgentEnable { get; set; }

    /// <summary>
    /// TwoLevelAgent Enable的默认值
    /// </summary>
    const bool DefaultTwoLevelAgentEnable = false;

    /// <summary>
    /// TwoLevelAgent ProxyType
    /// </summary>
    short? TwoLevelAgentProxyType { get; set; }

    /// <summary>
    /// TwoLevelAgent ProxyType的默认值
    /// </summary>
    const short DefaultTwoLevelAgentProxyType = (short)IReverseProxyService.Constants.DefaultTwoLevelAgentProxyType;

    /// <summary>
    /// 二级代理 IP
    /// </summary>
    string? TwoLevelAgentIp { get; set; }

    /// <summary>
    /// 二级代理 IP的默认值
    /// </summary>
    static readonly string DefaultTwoLevelAgentIp = IPAddress.Loopback.ToString();

    /// <summary>
    /// 二级代理 监听端口
    /// </summary>
    int? TwoLevelAgentPortId { get; set; }

    /// <summary>
    /// 二级代理 监听端口的默认值
    /// </summary>
    const int DefaultTwoLevelAgentPortId = 7890;

    /// <summary>
    /// TwoLevelAgent UserName
    /// </summary>
    string? TwoLevelAgentUserName { get; set; }

    /// <summary>
    /// TwoLevelAgent UserName的默认值
    /// </summary>
    const string? DefaultTwoLevelAgentUserName = null;

    /// <summary>
    /// TwoLevelAgent Password
    /// </summary>
    string? TwoLevelAgentPassword { get; set; }

    /// <summary>
    /// TwoLevelAgent Password的默认值
    /// </summary>
    const string? DefaultTwoLevelAgentPassword = null;

    #endregion

    #region 代理模式设置

    /// <summary>
    /// 当前代理模式
    /// </summary>
    ProxyMode? ProxyMode { get; set; }

    /// <summary>
    /// 当前代理模式的默认值
    /// </summary>
    static readonly ProxyMode DefaultProxyMode = Enums.ProxyMode.Hosts;

    #endregion

#if (WINDOWS || MACCATALYST || MACOS || LINUX) && !(IOS || ANDROID)

    /// <summary>
    /// 启用 GOG 插件代理
    /// </summary>
    bool? IsProxyGOG { get; set; }

    /// <summary>
    /// 启用 GOG 插件代理的默认值
    /// </summary>
    const bool DefaultIsProxyGOG = false;

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本
    /// </summary>
    bool? IsOnlyWorkSteamBrowser { get; set; }

    /// <summary>
    /// 是否只针对 Steam 内置浏览器启用脚本的默认值
    /// </summary>
    const bool DefaultIsOnlyWorkSteamBrowser = false;

#endif

}
