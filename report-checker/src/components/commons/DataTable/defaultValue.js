import Images from './../../../constants/Images'

export const Params = {
  HeaderUneditable: [
    { name: 'STT', width: '10%' },
    { name: 'Tên sản phẩm', width: '46%' },
    { name: 'Màu sắc', width: '22%' },
    { name: 'Size', width: '13%' },
    { name: 'SL', width: '9%' }
  ],
  HeaderEditable: [
    { name: 'STT', width: '10%' },
    { name: 'Tên sản phẩm', width: '41%' },
    { name: 'Màu sắc', width: '18%' },
    { name: 'Size', width: '13%' },
    { name: 'SL', width: '9%' },
    { name: null, width: '9%' }
  ],
  ButtonRemove: {
    size: 'small',
    icon: {
      normal: Images.REMOVE_ICON.STYLE_1,
      selected: Images.REMOVE_ICON.STYLE_2
    }
  }
}
