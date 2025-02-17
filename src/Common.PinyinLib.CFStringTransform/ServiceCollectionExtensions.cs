using CoreFoundation;
using System.Application.Services;
using System.Application.Services.Implementation;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// 添加使用 <see cref="CFStringTransform"/> 实现的拼音功能
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddPinyinCFStringTransform(this IServiceCollection services)
    {
        services.AddSingleton<IPinyin, PinyinImpl>();
        return services;
    }

    /// <inheritdoc cref="AddPinyinCFStringTransform(IServiceCollection)"/>
    public static IServiceCollection AddPinyin(this IServiceCollection services) => services.AddPinyinCFStringTransform();
}