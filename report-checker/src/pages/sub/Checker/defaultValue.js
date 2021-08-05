import Images from './../../../constants/Images'

export const Params = {
  Title: {
    size: 'medium',
    name: {
      left: 'Dữ liệu thô',
      right: 'Bảng tổng'
    }
  },
  ButtonNormal: {
    size: 'small',
    name: {
      transform: 'Chuyển đổi',
      clear: 'Xóa',
      undo: 'Quay lại',
      store: 'Lưu trữ'
    }
  },
  ButtonIcon: {
    size: 'small',
    undo: {
      icon: {
        normal: Images.UNDO_ICON.STYLE_1,
        selected: Images.UNDO_ICON.STYLE_2
      },
      tooltip: 'Quay lại'
    },
    redo: {
      icon: {
        normal: Images.REDO_ICON.STYLE_1,
        selected: Images.REDO_ICON.STYLE_2
      },
      tooltip: 'Hồi quay lại'
    }
  },
  RadioButton: {
    data: [
      {
        name: 'Loại 1',
        value: 0
      },
      {
        name: 'Loại 2',
        value: 1
      }
    ]
  },
  InputTextarea: {
    height: '270px'
  },
  Table: {
    height: '320px'
  }
}
