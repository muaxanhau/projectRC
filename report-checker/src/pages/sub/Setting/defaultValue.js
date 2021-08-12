import Images from './../../../constants/Images'

export const Params = {
  Range: {
    width: '320px',
    unit: '%',
    appSize: {
      name: 'Kích thước',
      min: 75,
      max: 200
    },
    fontSize: {
      name: 'Cỡ chữ',
      min: 50,
      max: 150
    },
    brightness: {
      name: 'Độ sáng màn hình',
      min: 50,
      max: 200
    }
  },
  ToggleThemeButton: {
    name: 'Phông nền',
    size: 'small',
    values: {
      val1: 'Sáng',
      val2: 'Tối'
    },
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
