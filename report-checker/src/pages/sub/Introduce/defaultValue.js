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
      'Hoàng Ngọc Thịnh',
      'Hoàng Ngọc Thịnh',
      'Hoàng Ngọc Thịnh',
      'Hoàng Ngọc Thịnh',
      'Hoàng Ngọc Thịnh'
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
    avatar: Params.Member.avatar.images[0],
    name: 'Hoàng Ngọc Thịnh',
    info: 'Quản trị viên',
    message:
      'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati aut illum! Praesentium delectus laboriosam, quisquam ad hic soluta distinctio quas doloremque alias vel a harum! Dignissimos, corrupti?'
  },
  {
    width: '70%',
    avatar: Params.Member.avatar.images[0],
    name: 'Hoàng Ngọc Thịnh',
    info: 'Quản trị viên',
    message:
      'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati aut illum! Praesentium delectus laboriosam, quisquam ad hic soluta distinctio quas'
  },
  {
    width: '100%',
    avatar: Params.Member.avatar.images[0],
    name: 'Hoàng Ngọc Thịnh',
    info: 'Quản trị viên',
    message:
      'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati aut illum! Praesentium delectus laboriosam, quisquam'
  },
  {
    width: '60%',
    avatar: Params.Member.avatar.images[0],
    name: 'Hoàng Ngọc Thịnh',
    info: 'Quản trị viên',
    message:
      'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati aut illum! Praesentium delectus laboriosam, quisquam ad hic soluta distinctio quas'
  }
]
