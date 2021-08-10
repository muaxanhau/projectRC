import Images from './../../../constants/Images'
import DefaultValue from './../../../constants/DefaultValues'

export const Params = {
  AppLogo: {
    size: 'large'
  },
  Member: {
    avatar: {
      size: 'large',
      images: Images.MEMBER.AVATARS
    },
    names: [
      'Trương Tuấn Anh',
      'Hoàng Ngọc Thịnh',
      'Võ Minh Dương',
      'Phan Gia Nhựt',
      'Hồ Sơn Thạnh'
    ]
  },
  Title: {
    text: DefaultValue.APP_NAME,
    size: 'medium'
  },
  Separator: {
    width: '30%'
  }
}

export const MessageData = [
  {
    width: '80%',
    avatar: Params.Member.avatar.images[4],
    name: 'Hồ Sơn Thạnh',
    info: 'Thành viên',
    message:
      'Chúng tôi cố gắng giúp đỡ các bạn trong việc lưu trữ thông tin khách hàng.'
  },
  {
    width: '70%',
    avatar: Params.Member.avatar.images[1],
    name: 'Hoàng Ngọc Thịnh',
    info: 'Người phát triển',
    message:
      'Luôn lắng nghe phản hồi từ các người dùng. Cải tiến các tính năng, tăng trải nghiệm.'
  },
  {
    width: '80%',
    avatar: Params.Member.avatar.images[3],
    name: 'Phan GIa Nhựt',
    info: 'Nhà đồng hành',
    message:
      'Tại sao các bạn nên chọn chúng tôi? Vì nó có tất cả những tính năng phù hợp. Chúng tôi cam kết hỗ trợ người dùng liên tục.'
  },
  {
    width: '90%',
    avatar: Params.Member.avatar.images[2],
    name: 'Võ Minh Dương',
    info: 'Tổng hợp nội dung',
    message:
      'ReportChecker là một ứng dụng tuyệt vời giúp cho việc bán hàng trực tuyến trở nên dễ dàng, đơn giản, phù hợp với tình hình hiện tại.'
  },
  {
    width: '65%',
    avatar: Params.Member.avatar.images[0],
    name: 'Trương Tuấn Anh',
    info: 'Thành viên',
    message: 'Các bạn sẽ hài lòng khi trải nghiệm sản phẩm của chúng tôi.'
  }
]
