﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过以下
// 特性集控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("12306_Helper")]
[assembly: AssemblyDescription(@"
声明：本程序仅供学习和研究C#技术使用

2.1.0.0
[+] 增加自动抢票功能

2.1.1.0
[+] 增加保存登录信息功能

2.1.2.0
[*] 修复自动抢票后，关闭订单提交窗口导致的程序退出
[*] 修复安全期不起作用

2.1.3.0
[*] 修复自动抢票不受控制的弹出窗口
[*] 修复筛选中其它按钮无效的bug

2.1.4.0
[+] 增加处理提交订单页面的坐席列表
[*] 修复退出订单提交页面时主页面闪烁问题
[*] 修复自动抢票显示的提交页面不能选择列表中的项的问题

2.1.5.0
[+] 增加处理余票数量显示
[+] 增加Cookie保存和读取

2.2.0.0
[+] 增加未完成订单查询和取消订单
[+] 增加历史订单查询

2.2.1.0
[*] 修复联系人显示不完整
[*] 修复一些其它小BUG

2.2.2.0
[*] 修复订单出现乱码的情况

2.2.3.0
[*] 修复权限不足的问题

2.2.4.0
[*] 修复订票成功后无限弹出提示的bug
[*] 修复抢票后不能定位座类的bug

2.2.5.0
[+] 增加服务器时间显示

2.2.6.0
[*] 修复乘车人列表显示没有滚动条的问题
[+] 增加更换帐号功能

2.2.7.0
[*] 修复部分座类代码问题

2.2.8.0
[*] 修复一等软卧、二等软卧无法预定的问题
[+] 增加音乐提示
[-] 删除老的窗体和代码

2.2.9.0
[+] 增加轮查功能

2.2.10.0
[+] 增加对未处理异常的捕获，并记录日志
[+] 增加对缓存信息的显示
[+] 增加时间段筛选
[+] 增加保存个人配置信息

2.2.11.0
[+] 增加自动更新

2.3.1.0
[!] 优化订票流程
[*] 修复未完成订单显示错位
[+] 增加未完成订单详细信息显示
[*] 修复订票过程中的一些小BUG
[+] 增加对排队人数大于余票人数的自动提交(需要每次输入验证码)
[*] 修复提交窗口中安全期内按回车提交的BUG

2.3.2.0
[+] 增加托盘显示和切换帐号提示
[*] 修复取消订单按钮不直接显示的问题
[*] 修复当余票大于999时余票显示错误的问题

2.3.3.0
[*] 小小的优化无座是默认坐席的情况
[+] 增加版本号显示
[+] 增加蹲点抢票提示(以前很多人不知道抢票按钮旁边的那个带复选框的日期是干什么的)
[+] 增加自定义过滤火车类型

2.3.4.0
[*] 优化订单提交页面坐席余票显示顺序
[+] 丰富日志记录内容和范围
[+] 增加订单提交页面票价显示
[+] 增加列车数量显示

2.3.5.0
[*] 优化部分代码
[*] 修改了图标
[*] 修改自定义过滤默认值
[*] 修复了一些“非法订票请求”的成因
[*] 修复有未完成订单时助手的各种错误。
[*] 修复未完成订单中个别信息无法完全显示的问题
[*] 修复了未提交订单窗口中，不显示余票不足时产生的“假”订单的BUG
[+] 加强了对未完成订单的限制，在订单查询窗口增加“登录到IE”按钮
[+] 增加起售时间查询窗口
[+] 增加12306主页上的最新动态窗口
[+] 增加对用户名和密码的加密

2.3.6.0
[*] 优化了大部分代码，最大限度的提高了订票速度
[*] 修复了无法保存登录信息的错误
[*] 修复了切换帐号时的一些BUG
[*] 修复了预定时偶尔超时的问题

2.3.6.1
[*] 修复上一版本导致的无法显示票价和查询无票时的提示

2.3.6.2
[*] 精确了一下安全期计时

2.3.7.0
[+] 增加经过车站信息查看
[*] 修复最新动态偶尔无法加载的问题

2.3.7.5
[*] 优化了点击预定后的默认坐席选择
[*] 优化了代码
[*] 更改了部分提示信息
[-] 删除了链接类
[*] 修复了窗体名称和图标的显示

2.3.7.6
[*] 订票成功后自动跳转到网页。

2.3.8.0
[*] 修改标题字体颜色
[+] 增加常规讨论、BUG提交、反馈建议、开发者讨论、软件下载主页的快捷链接，大家有问题可以直接过去提交哦~~

2.3.8.1
[*] 修复更新的错误
[*] 改善加载个人配置信息的日期选择方式

2.4.0.0
[+] 增加自动切换解析服务器功能开关
[*] 修复最新动态无法直接打开网页的问题

2.4.1.1
[*] 修复一些已知的BUG
[+] 增加Hosts的一些提示

2.4.2.0
[*] 修复了一些已知的BUG
[+] 增加了解析地址源
[*] 精确了蹲点抢票的设置(一般会在服务器正点之后的1~2秒内开始)
[+] 增加订单成功后是否自动打开IE的选项
[-] 去掉订单提交页面的“登录到IE”按钮

2.4.2.1
[*] 修复一些BUG (郁闷~才发现)

2.4.2.2
[*] 修正一些小问题

2.4.2.3
[*] 修复hosts文件无法访问时无法使用的BUG
[+] 增加服务器切换窗口

2.4.2.4
[*] 修改一些提交方式和显示样式
[+] 增加对IP切换的控制

2.4.3.0
[*] 修复一些BUG
[+] 增加瓦房店西
[+] 增加编辑联系人,暂时不支持修改非成人信息

2.4.4.0
[*] 修复一些BUG
[+] 增加添加联系人功能(暂时只能添加成人)
[+] 增加手动切换服务器功能

2.4.5.0
[*] 修复查询起售时间的BUG
[*] 修复无法修改姓名和证件的BUG

2.4.5.5
[*] 修改当无座票不可售时，订票页面对无座的处理

2.4.5.6
[*] 修复第一次登录成功后无法加载联系人的问题（第一次加载可能过慢）

2.4.6.0
[+] 增加几个未录入的车站
[+] 在登录窗体中增加服务器自动切换功能(隐藏)

2.4.6.3
[*] 优化了车次列表的着色方法
[*] 修复对无座处理的BUG

2.4.6.4
[*] 修复了一些查询无法加载的问题
")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("http://www.cnblogs.com/StupidsCat/")]
[assembly: AssemblyProduct("12306_Helper")]
[assembly: AssemblyCopyright("Copyright © aNyoNe pengyouak@163.com")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("c6b8c68e-f8c7-47cf-992b-bc13a4000988")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本 
//      内部版本号
//      修订号
//
// 可以指定所有这些值，也可以使用“内部版本号”和“修订号”的默认值，
// 方法是按如下所示使用“*”:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2.4.6.4")]
[assembly: AssemblyFileVersion("2.4.6.4")]
[assembly: FSLib.App.SimpleUpdater.Updatable2("http://www.fishlee.net/service/update/51/{0}", "update_c.xml")]
