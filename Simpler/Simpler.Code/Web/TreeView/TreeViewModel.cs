/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
namespace Simpler.Code
{
    public class TreeViewModel
    {
        public string parentId { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
        public int? checkstate { get; set; }
        public bool showcheck { get; set; }
        public bool complete { get; set; }
        public bool isexpand { get; set; }
        public bool hasChildren { get; set; }
        public string img { get; set; }
        public string title { get; set; }
    }
}
