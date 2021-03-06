﻿Namespace ShanXingTech.Win32API
    Partial Public Module UnsafeNativeMethods
        Public Const SET_FEATURE_ON_PROCESS = &H2
        Public Const EM_SETCUEBANNER As Integer = &H1501
        Public Const S_OK As Integer = &H0
        Public Const E_INVALIDARG As Integer = &H80070057
        Public Const URLMON_OPTION_USERAGENT As Integer = &H1000_0001
        Public Const URLMON_OPTION_USERAGENT_REFRESH As Integer = &H10000002
        Public Const WM_NCLBUTTONDOWN As Integer = &HA1
        Public Const HT_CAPTION As Integer = &H2
        ''' <summary>
        ''' 异步播放
        ''' </summary>
        Public Const SND_ASYNC = &H1
        ''' <summary>
        ''' 循环播放
        ''' </summary>
        Public Const SND_LOOP = &H8
        Public Const INTERNET_OPTION_SUPPRESS_BEHAVIOR As Integer = 81
        Public Const INTERNET_SUPPRESS_COOKIE_PERSIST As Integer = 3
        Public Const INTERNET_SUPPRESS_COOKIE_PERSIST_RESET As Integer = 4
        Public Const INTERNET_OPTION_END_BROWSER_SESSION As Integer = 42
        Public Const WM_CLOSE = &H10
        Public Const WM_CLICK = &HF5
        Public Const WM_COPYDATA As Integer = &H4A
        Public Const WM_SETFOCUS As Integer = &H7
        Public Const HWND_BOTTOM As Integer = &H1
        Public Const HWND_NOTOPMOST As Integer = -&H2
        Public Const HWND_TOPMOST As Integer = -&H1
        Public Const HWND_TOP As Integer = &H0
        Public Const MK_CONTROL = &H8
        Public Const MK_LBUTTON = &H1
        Public Const MK_MBUTTON = &H10
        Public Const MK_RBUTTON = &H2
        Public Const MK_SHIFT = &H4
        Public Const WM_HOTKEY = &H312
        Public Const GWL_WNDPROC = (-4)
    End Module
End Namespace