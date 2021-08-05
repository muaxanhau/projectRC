import Images from './../../../constants/Images'

export const Params = {
  Range: {
    width: '320px',
    min: 75,
    max: 125,
    unit: '%',
    name: {
      appSize: 'Kích thước',
      fontSize: 'Cỡ chữ',
      brightness: 'Độ sáng màn hình',
      theme: 'Phông nền'
    }
  },
  ToggleThemeButton: {
    size: 'small',
    icon: {
      type1: Images.SUN_ICON,
      type2: Images.MOON_ICON
    }
  },
  ButtonNormal: {
    name: {
      apply: 'Áp dụng',
      default: 'Mặc định'
    },
    size: 'small'
  }
}
