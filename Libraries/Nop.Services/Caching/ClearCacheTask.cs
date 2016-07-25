using F1sh.Core.Caching;
using F1sh.Core.Infrastructure;
using F1sh.Services.Tasks;

namespace F1sh.Services.Caching
{
    /// <summary>
    /// Clear cache schedueled task implementation
    /// </summary>
    public partial class ClearCacheTask : ITask
    {
        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            var cacheManager = EngineContext.Current.ContainerManager.Resolve<ICacheManager>("F1sh_cache_static");
            cacheManager.Clear();
        }
    }
}
