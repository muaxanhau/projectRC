import Images from './../../constants/Images'
import Checker from './../sub/Checker/index'
import Analyst from './../sub/Analyst/index'
import Help from './../sub/Help/index'

export const Params = {
  AppLogo: {
    size: 'small'
  },
  AppName: {
    size: 'medium'
  },
  ToggleMenuButton: {
    tooltip: 'Bật - tắt menu',
    size: 'small',
    icon: {
      normal: Images.MENU_ICON.STYLE_1,
      selected: Images.MENU_ICON.STYLE_2
    }
  },
  LogoutButton: {
    tooltip: 'Đăng xuất',
    size: 'small',
    icon: {
      normal: Images.LOGOUT_ICON.STYLE_1,
      selected: Images.LOGOUT_ICON.STYLE_2
    }
  },
  RestoreButton: {
    tooltip: 'Khôi phục dữ liệu',
    size: 'small',
    icon: {
      normal: Images.RESTORE_ICON.STYLE_1,
      selected: Images.RESTORE_ICON.STYLE_2
    }
  },
  DraftButton: {
    tooltip: 'Lưu tạm dữ liệu, có thể khôi phục ở phiên làm việc kế tiếp',
    size: 'small',
    icon: {
      normal: Images.DRAFT_ICON.STYLE_1,
      selected: Images.DRAFT_ICON.STYLE_2
    }
  },
  ToggleThemeButton: {
    tooltip: 'Đổi nền',
    size: 'small',
    icon: {
      type1: Images.SUN_ICON,
      type2: Images.MOON_ICON
    }
  }
}
export const NavbarData = [
  {
    name: 'Kiểm hàng',
    icon: {
      normal: Images.JOB_ICON.STYLE_1,
      selected: Images.JOB_ICON.STYLE_2
    },
    linkTo: '/checker',
    element: <Checker />
  },
  {
    name: 'Thống kê',
    icon: {
      normal: Images.ANALYST_ICON.STYLE_1,
      selected: Images.ANALYST_ICON.STYLE_2
    },
    linkTo: '/analyst',
    element: <Analyst />
  },
  {
    name: 'Trợ giúp',
    icon: {
      normal: Images.GUILD_ICON.STYLE_1,
      selected: Images.GUILD_ICON.STYLE_2
    },
    linkTo: '/help',
    element: <Help />
  }
]
