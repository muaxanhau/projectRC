import AnalystAll from './../AnalystAll/index'
import AnalystDetail from './../AnalystDetail/index'
import AnalystChart from './../AnalystChart/index'

export const Params = {
  RadioButton: {
    size: 'small',
    width: 'calc(var(--font-size-small) * 8 * 3)'
  }
}
export const ContentData = [
  {
    name: 'Tất cả',
    value: 0,
    linkTo: '/all',
    element: <AnalystAll />
  },
  {
    name: 'Chi tiết',
    value: 1,
    linkTo: '/detail',
    element: <AnalystDetail />
  },
  {
    name: 'Biểu đồ',
    value: 2,
    linkTo: '/chart',
    element: <AnalystChart />
  }
]
