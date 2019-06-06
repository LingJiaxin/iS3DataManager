using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using iS3.Geology.Model;
using iS3.Core;
namespace iS3.MiniServer
{
    
    
    [RoutePrefix("api/Geology")]
    [Authorize(Roles = "Admin")]
    [AllowAnonymous]
    public class GeologyController : ApiController
    {
        /// <summary>
        /// 根据id获取工程钻孔数据
        /// </summary>
        /// <param name="project">项目名称</param>
        /// <param name="id">钻孔id</param>
        /// <returns> </returns>
        [Route("faul")]
        [HttpGet]
        public FAUL getFAULById(string project, int id)
        {

            return new FAUL();
        }
        /// <summary>
        /// 根据对象组获取钻孔
        /// </summary>
        /// <param name="project"></param>
        /// <param name="objsid"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Route("FAUL")]
        [HttpGet]
        public List<FAUL> getFAULByObjs(string project, int objsid, string filter)
        {
            var repo = RepositoryForServer<FAUL>.GetInstance(project);
            return repo.RetrieveByObjs(objsid, filter).Result;
        }
        /// <summary>
        /// 新增FAUL对象,连带其中的钻孔地层对象，如果有的话
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("FAUL")]
        [HttpPost]
        public FAUL postFAUL([FromUri]string project, [FromBody]FAUL model)
        {
            var repo = RepositoryForServer<FAUL>.GetInstance(project);
            return repo.Create(model).Result;
        }
        /// <summary>
        /// 更新钻孔信息，不更新其中的钻孔地层对象信息
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("FAUL")]
        [HttpPut]
        public FAUL putFAUL([FromUri]string project, [FromBody]FAUL model)
        {
            var repo = RepositoryForServer<FAUL>.GetInstance(project);
            return repo.Update(model).Result;
        }
        /// <summary>
        /// 删除钻孔对象，同时删除对应的钻孔地层对象
        /// </summary>
        /// <param name="project"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("FAUL")]
        [HttpDelete]
        public int deleteFAUL([FromUri]string project, [FromBody]FAUL model)
        {
            
            return repo.Delete(model).Result;
        }
        
    }
}
