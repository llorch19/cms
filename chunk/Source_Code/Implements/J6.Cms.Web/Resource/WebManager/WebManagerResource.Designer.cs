﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace J6.Cms.Web.Resource.WebManager {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class WebManagerResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WebManagerResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("J6.Cms.Web.Resource.WebManager.WebManagerResource", typeof(WebManagerResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;文档标签替换&lt;/title&gt;
        ///    $css()
        ///	&lt;/head&gt;
        ///	&lt;body style=&quot;padding:30px&quot;&gt;
        ///	&lt;div&gt;
        ///        注：使用此功能可以将整个站点的文档的关键词进行批量自动添加内链！
        ///        &lt;br /&gt;&lt;br /&gt;&lt;br /&gt;
        ///    &lt;/div&gt;
        ///     &lt;input class=&quot;btn&quot; type=&quot;button&quot; onclick=&quot;batReplace()&quot; value=&quot;批量替换&quot; /&gt;
        ///     &lt;div id=&quot;msg&quot;&gt;&lt;/div&gt;
        ///     
        ///	$js()
        ///     &lt;script type=&quot;text/javascript&quot;&gt;
        ///       var msg = j6.$(&apos;msg&apos;);
        ///       function batReplace(t) {
        ///         if (confirm(&apos;需要较长时间，确定继续吗？&apos;)) {
        ///           msg.innerHTML = &apos;更新中....&apos;;
        ///        [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string archiveTagReplace {
            get {
                return ResourceManager.GetString("archiveTagReplace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;表格列列表&lt;/title&gt;
        ///        $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///	 &lt;div class=&quot;tabarea&quot;&gt;
        ///
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=all&quot;&gt;所有表&lt;/a&gt;
        ///        &lt;a href=&quot;javascript:;&quot;  class=&quot;current&quot;&gt;结构&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=createcolumn&amp;amp;tableid=${tableid}&quot; id=&quot;btnlink_create&quot;&gt;创建列&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;action=rows&amp;control=true&amp;tableid=${tableid}&quot;&gt;数据&lt;/a&gt;
        ///        &lt;span class=&quot;meta&quot;&gt;表名：&lt;span&gt;${tablename}&lt;/span&gt;&lt;/spa [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string columns {
            get {
                return ResourceManager.GetString("columns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;数据采集&lt;/title&gt;
        ///        $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///        &lt;iframe id=&quot;area&quot; src=&quot;/frameworkplugins/collection.ashx?action=createproject&quot;  scrolling=&quot;auto&quot; frameborder=&quot;0&quot; width=&quot;100%&quot; height=&quot;100%&quot;&gt;&lt;/iframe&gt;
        ///  $js()
        ///&lt;script type=&quot;text/javascript&quot;&gt;
        /// j6.$(&apos;area&apos;).style.height = (document.documentElement.clientHeight - 69) + &apos;px&apos;;
        ///&lt;/script&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt; 的本地化字符串。
        /// </summary>
        public static string createdatapickerproject {
            get {
                return ResourceManager.GetString("createdatapickerproject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;&lt;/title&gt;
        ///        $css()$js()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///        &lt;iframe id=&quot;area&quot; src=&quot;/frameworkplugins/collection.ashx?action=list&quot;  scrolling=&quot;auto&quot; frameborder=&quot;0&quot; width=&quot;100%&quot; height=&quot;100%&quot;&gt;&lt;/iframe&gt;
        ///
        ///
        ///&lt;script type=&quot;text/javascript&quot;&gt;
        /// j6.$(&apos;area&apos;).style.height = (document.documentElement.clientHeight - 69) + &apos;px&apos;;
        ///&lt;/script&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt; 的本地化字符串。
        /// </summary>
        public static string datapicker {
            get {
                return ResourceManager.GetString("datapicker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;创建列&lt;/title&gt;$css()
        ///&lt;/head&gt;
        ///&lt;body&gt;
        /// &lt;div class=&quot;tabarea&quot;&gt;
        ///
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=all&quot;&gt;所有表&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=columns&amp;amp;tableid=${tableid}&quot;  class=&quot;current&quot; id=&quot;btnlink&quot;&gt;结构&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=createcolumn&amp;amp;tableid=${tableid}&quot; id=&quot;btnlink_create&quot;&gt;创建列&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=rows&amp;amp;control=true&amp;amp;tableid=${tableid}&quot;&gt;数据&lt;/a&gt;
        ///       [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string editcolumn {
            get {
                return ResourceManager.GetString("editcolumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;模块修改&lt;/title&gt;$css()
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///        &lt;form action=&quot;&quot; method=&quot;post&quot;&gt;&lt;br /&gt;
        ///    &lt;div class=&quot;form&quot;&gt;
        ///        &lt;div class=&quot;tip&quot;&gt;
        ///            &lt;b&gt;什么是模块?&lt;/b&gt;&lt;br /&gt;
        ///            模块与栏目相关，栏目与文档相关。模块可以提供视图设置和自定义属性给栏目和文档。
        ///        &lt;/div&gt;&lt;br /&gt;
        ///        &lt;dl&gt;
        ///            &lt;dt&gt;模块名称：&lt;/dt&gt;&lt;dd&gt;&lt;input type=&quot;text&quot; class=&quot;tb_normal ui-validate&quot; required=&quot;true&quot; length=&quot;[0,10]&quot; field=&quot;tplname&quot; value=&quot;${tplName}&quot; summary=&quot;{required:&apos;不能为空&apos;,length:&apos;不能超过10个字&apos;}&quot;/&gt;&lt;/dd&gt;&lt;/dl&gt;
        ///        [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string editModule {
            get {
                return ResourceManager.GetString("editModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;title&gt;创建表格&lt;/title&gt;
        ///    $css()
        ///    &lt;script type=&quot;text/javascript&quot; src=&quot;/framework/assets/editor/minpack.js&quot;&gt;&lt;/script&gt;
        ///    &lt;script type=&quot;text/javascript&quot; src=&quot;/framework/assets/editor/plugins/code/prettify.js&quot;&gt;&lt;/script&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;div class=&quot;tabarea&quot;&gt;
        ///
        ///        &lt;div class=&quot;tab_mini&quot;&gt;
        ///            &lt;a href=&quot;?module=table&amp;amp;action=all&quot;&gt;所有表&lt;/a&gt;
        ///            &lt;a href=&quot;javascript:;&quot; class=&quot;current&quot; id=&quot;btnlink&quot;&gt;添加表&lt;/a&gt;
        ///        &lt;/div&gt;
        ///
        ///        &lt;div class=&quot;are [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string edittable {
            get {
                return ResourceManager.GetString("edittable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;span style=&quot;color:red&quot;&gt;√&lt;/span&gt; 的本地化字符串。
        /// </summary>
        public static string errorText {
            get {
                return ResourceManager.GetString("errorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap guest_avatar {
            get {
                object obj = ResourceManager.GetObject("guest_avatar", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///  &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=UTF-8&quot; /&gt;
        ///  &lt;title&gt;加载页面&lt;/title&gt;
        ///  $css()
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///  &lt;div id=&quot;pl&quot;&gt;&lt;/div&gt;$js()
        ///  &lt;script type=&quot;text/javascript&quot;&gt;
        ///      j6.load2(&apos;pl&apos;,&apos;system&apos;,&apos;summary&apos;,&apos;token=dsfg&apos;);
        ///  &lt;/script&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;
        /// 的本地化字符串。
        /// </summary>
        public static string index_main {
            get {
                return ResourceManager.GetString("index_main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //Core
        ///function j6l() { this.__VERSION__ = &apos;3.1&apos;; this.__WORKPATH__ = &apos;&apos;; this.__Extend_PROTOTYPE__ = true } j6l.prototype = { __init__: function () { if (this.__Extend_PROTOTYPE__) { this.__extendingJsPrototype__() } var f = document.getElementsByTagName(&apos;SCRIPT&apos;); var s = f[f.length - 1]; var g = s.src; this.__WORKPATH__ = g.replace(/(\/)[^/]+$/, &apos;$1&apos;); if (!document.getElementsByClassName) { document.getElementsByClassName = function (a, b) { if (b &amp;&amp; !b.nodeName) { b = document.getElementById(b) } var  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string manage_js_min {
            get {
                return ResourceManager.GetString("manage_js_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;会员列表&lt;/title&gt;
        ///    $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///    
        ///	        &lt;div id=&quot;memberlist&quot;&gt;
        ///                ${memberRowsHtml}
        ///            &lt;/div&gt;
        ///            &lt;br /&gt;&lt;br /&gt;
        ///            &lt;div class=&quot;pager&quot;&gt;${pagerHtml}&lt;/div&gt;
        ///
        ///
        ///$js()
        ///&lt;script type=&quot;text/javascript&quot;&gt;
        ///  function showProfile(id) {
        ///    window.open(&apos;/member/profile/&apos; + id);
        ///  }
        ///  function deleteMember(t, id) {
        ///    var b = confirm(&apos;是否删除改会员的评论及文章信息?&apos;);
        ///    j6.xhr.post(&apos;/app.axd&apos;, &apos;do=member:delete:&apos; + id +  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string memberList {
            get {
                return ResourceManager.GetString("memberList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;模块列表&lt;/title&gt;
        ///    $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///&lt;div class=&quot;tabarea1&quot;&gt;
        ///
        ///    &lt;!--
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;javascript:;&quot; class=&quot;current&quot;&gt;模块列表&lt;/a&gt;
        ///        &lt;a href=&quot;?module=module&amp;amp;action=create&quot;&gt;创建模块&lt;/a&gt;
        ///    &lt;/div&gt;
        ///    --&gt;
        ///
        ///    &lt;table class=&quot;ui-table&quot; id=&quot;gd&quot; cellpadding=&quot;0&quot; cellspacing=&quot;1&quot;&gt;
        ///      &lt;tr&gt;
        ///        &lt;th width=&quot;40&quot;&gt;&lt;span class=&quot;th&quot;&gt;编号&lt;/span&gt;&lt;/th&gt;
        ///        &lt;th width=&quot;100&quot;&gt;&lt;span class=&quot;th&quot;&gt;模块名称&lt;/span&gt;&lt;/th&gt;
        ///        &lt;th width=&quot;60&quot; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string moduleList {
            get {
                return ResourceManager.GetString("moduleList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;操作列表&lt;/title&gt;
        ///    $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;	
        ///
        ///&lt;div class=&quot;_tabarea&quot;&gt;
        ///&lt;!--
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;?module=user&amp;amp;action=systemuserlist&quot;&gt;系统用户&lt;/a&gt;
        ///        &lt;a href=&quot;?module=user&amp;amp;action=setpermissions&quot;&gt;用户组权限设置&lt;/a&gt;
        ///        &lt;a href=&quot;javascript:;l&quot; class=&quot;current&quot;&gt;权限管理&lt;/a&gt;
        ///    &lt;/div&gt;
        ///    --&gt;
        ///        &lt;div class=&quot;area&quot;&gt;
        ///
        ///&lt;table class=&quot;ui-table&quot; cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; id=&quot;operations&quot;&gt;
        ///      &lt;tr&gt;
        ///        &lt;th width=&quot;40&quot;&gt;编号&lt;/th&gt;
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string operationList {
            get {
                return ResourceManager.GetString("operationList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///  &lt;title&gt;加载页面&lt;/title&gt;
        ///  $js()$css()
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///  &lt;div id=&quot;pl&quot;&gt;&lt;/div&gt;
        ///  &lt;script type=&quot;text/javascript&quot;&gt;
        ///      j6.$(&apos;pl&apos;).style.height = document.documentElement.clientHeight + &apos;px&apos;;
        ///      j6.load(&apos;pl&apos;,&apos;?&apos;+location.search.replace(&apos;?load=&apos;,&apos;&apos;));
        ///  &lt;/script&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;
        /// 的本地化字符串。
        /// </summary>
        public static string pageLoading {
            get {
                return ResourceManager.GetString("pageLoading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///  &lt;title&gt;安装系统补丁&lt;/title&gt;
        ///  $css()
        ///  &lt;style type=&quot;text/css&quot;&gt;
        ///  #patchlist div{line-height:25px;}
        ///  &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;div class=&quot;tabarea&quot; style=&quot;padding:30px&quot;&gt;
        ///&lt;!--
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;javascript:;&quot; class=&quot;current&quot;&gt;安装补丁&lt;/a&gt;
        ///    &lt;/div&gt;
        ///    &lt;div class=&quot;area&quot; id=&quot;area&quot;&gt;
        ///    --&gt;
        ///    &lt;form action=&quot;?module=system&amp;action=patchupload&quot; method=&quot;post&quot;  enctype=&quot;multipart/form-data&quot;&gt;
        ///        上传补丁：&lt;input type=&quot;file&quot; name=&quot;patchfile&quot;  id=&quot;patchfi [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string patch {
            get {
                return ResourceManager.GetString("patch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;span style=&quot;color:green&quot;&gt;√&lt;/span&gt; 的本地化字符串。
        /// </summary>
        public static string rightText {
            get {
                return ResourceManager.GetString("rightText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///   @control : 显示控制按钮
        ///
        ///*/
        ///&lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;表格行列表&lt;/title&gt;
        ///        $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///	
        ///  &lt;div class=&quot;tabarea&quot;&gt;
        ///
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        ${controlHtml}
        ///        &lt;span class=&quot;meta&quot;&gt;表名：&lt;span&gt;${tablename}&lt;/span&gt;&lt;/span&gt;
        ///    &lt;/div&gt;
        ///
        ///    &lt;table class=&quot;ui-table&quot; cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; id=&quot;gd&quot;&gt;
        ///      ${columnsHtml}
        ///      ${rowsHtml}
        ///    &lt;/table&gt;
        ///    &lt;div class=&quot;pager&quot;&gt;${pagerHtml}&lt;/div&gt;
        ///&lt;/div&gt;
        ///
        ///$js()
        ///&lt;script type=&quot;text/javascript&quot;&gt;
        ///
        ///    var [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string rows {
            get {
                return ResourceManager.GetString("rows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;更新权限&lt;/title&gt;
        ///    $css()
        ///	&lt;/head&gt;
        ///	&lt;body class=&quot;p10&quot;&gt;
        ///	 &lt;div class=&quot;_tabarea&quot;&gt;
        ///     &lt;!--
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;?module=user&amp;amp;action=systemuserlist&quot;&gt;系统用户&lt;/a&gt;
        ///        &lt;a href=&quot;javascript:;&quot; class=&quot;current&quot;&gt;用户组权限设置&lt;/a&gt;
        ///        &lt;a href=&quot;?module=user&amp;amp;action=operationlist&amp;amp;filter=all&quot;&gt;权限管理&lt;/a&gt;
        ///    &lt;/div&gt;--&gt;
        ///        &lt;div class=&quot;area&quot;&gt;
        ///            &lt;div&gt;选择用户组：&lt;select class=&quot;tb_normal&quot;id=&quot;groups&quot;&gt;${usergroups}&lt;/select&gt;&lt;br /&gt;&lt;/div&gt;
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string setPermissions {
            get {
                return ResourceManager.GetString("setPermissions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;模块列表&lt;/title&gt;
        ///    $css()
        ///    &lt;style type=&quot;text/css&quot;&gt;
        ///      #properties{padding:0 0 20px 0;}
        ///      #properties h2{font-size:12px;background:#f0f0f0;padding:5px 12px;}
        ///      #properties p{margin-left:10px;clear:both;}
        ///      span.add{position:absolute;top:7px;left:210px;}
        ///      #h1{padding:0 20px;}
        ///      .topbar{height:25px;line-height:25px;margin:10px 0 0;background:#f0f0f0;}
        ///      .topbar span{display:block;float:left;text-align:center;}
        ///      .tb_normal{wi [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string setProperties {
            get {
                return ResourceManager.GetString("setProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap sys_bg {
            get {
                object obj = ResourceManager.GetObject("sys_bg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap sys_tab {
            get {
                object obj = ResourceManager.GetObject("sys_tab", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap sysindex {
            get {
                object obj = ResourceManager.GetObject("sysindex", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap syslogin {
            get {
                object obj = ResourceManager.GetObject("syslogin", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap syslogin_bg {
            get {
                object obj = ResourceManager.GetObject("syslogin_bg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;config&gt;
        ///  &lt;menu&gt;
        ///    &lt;bar id=&quot;home&quot; name=&quot;我的首页&quot;&gt;
        ///      &lt;links title=&quot;欢迎使用&quot; toggle=&quot;true&quot; iconPos=&quot;-240|0&quot;&gt;
        ///        &lt;link href=&quot;?module=system&amp;amp;action=welcome&quot; text=&quot;欢迎首页&quot; title=&quot;&quot; siteid=&quot;-1&quot;/&gt;
        ///        &lt;link href=&quot;?module=system&amp;amp;action=serverSummary&quot; text=&quot;系统运行信息&quot; title=&quot;&quot; siteid=&quot;-1&quot;/&gt;
        ///        &lt;link href=&quot;http://www.j6.cc/cms/help.html&quot; text=&quot;帮助指南&quot; title=&quot;&quot; siteid=&quot;-1&quot;/&gt;
        ///        &lt;link href=&quot;http://www.j6.cc/cms/about.html&quot; text=&quot;关于系统&quot; title=&quot;&quot; siteid= [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string sysset_conf {
            get {
                return ResourceManager.GetString("sysset_conf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;表列表&lt;/title&gt;
        ///        $css()
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///	 &lt;div class=&quot;tabarea&quot;&gt;
        ///
        ///    &lt;div class=&quot;tab_mini&quot;&gt;
        ///        &lt;a href=&quot;javascript:;&quot; class=&quot;current&quot;&gt;所有表&lt;/a&gt;
        ///        &lt;a href=&quot;?module=table&amp;amp;action=create&quot;&gt;创建表&lt;/a&gt;
        ///    &lt;/div&gt;
        ///
        ///    &lt;table class=&quot;ui-table&quot; cellspacing=&quot;0&quot; cellpadding=&quot;0&quot; id=&quot;gd&quot;&gt;
        ///      &lt;tr&gt;
        ///        &lt;th width=&quot;70&quot;&gt;表格编号&lt;/th&gt;
        ///        &lt;th width=&quot;100&quot;&gt;表名&lt;/th&gt;
        ///        &lt;th width=&quot;90&quot;&gt;列(点击编辑)&lt;/th&gt;
        ///        &lt;th width=&quot;90&quot;&gt;行(点击查看)&lt;/th&gt;
        ///        &lt;th wi [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string tables {
            get {
                return ResourceManager.GetString("tables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 eval(function (p, a, c, k, e, r) { e = function (c) { return (c &lt; a ? &apos;&apos; : e(parseInt(c / a))) + ((c = c % a) &gt; 35 ? String.fromCharCode(c + 29) : c.toString(36)) }; if (!&apos;&apos;.replace(/^/, String)) { while (c--) r[e(c)] = k[c] || e(c); k = [function (e) { return r[e] }]; e = function () { return &apos;\\w+&apos; }; c = 1 }; while (c--) if (k[c]) p = p.replace(new RegExp(&apos;\\b&apos; + e(c) + &apos;\\b&apos;, &apos;g&apos;), k[c]); return p }(&apos;4(!9.17){9.17=\&apos;2T\&apos;}9.2U=[];9.2V=s;4(9.28==1K){12.1L.29(9.17+\&apos;?1q=1r&amp;1s=2W\&apos;,6(x){3 a,2X,2a,2b;2Y(x);9 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string ui_component {
            get {
                return ResourceManager.GetString("ui_component", resourceCulture);
            }
        }
    }
}
