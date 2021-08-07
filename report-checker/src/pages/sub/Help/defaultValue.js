import Introduce from './../Introduce/index'
import Guild from './../Guild/index'
import Setting from './../Setting/index'

export const Params = {
  RadioButton: {
    size: 'small',
    width: '43%'
  }
}
export const ContentData = [
  {
    name: 'Giới thiệu',
    value: 0,
    linkTo: '/introduce',
    element: <Introduce />
  },
  {
    name: 'Hướng dẫn',
    value: 1,
    linkTo: '/guild',
    element: <Guild />
  },
  {
    name: 'Cài đặt',
    value: 2,
    linkTo: '/setting',
    element: <Setting />
  }
]
