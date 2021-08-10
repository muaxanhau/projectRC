import React from 'react'
import { Params, MessageData } from './defaultValue'
import { Wrapper, IntroArea, MemberAvatarsArea, DetailsArea } from './elements'
import AppLogo from './../../../components/commons/AppLogo/index'
import Title from './../../../components/commons/Title/index'
import Avatar from './../../../components/commons/Avatar/index'
import Separator from './../../../components/commons/Separator/index'
import MessageForm from './../../../components/commons/MessageForm/index'

const Introduce = () => {
  return (
    <Wrapper>
      <IntroArea>
        <AppLogo size={Params.AppLogo.size} />
        <Title text='Các thành viên' size='small' />
        <MemberAvatarsArea>
          {Params.Member.avatar.images.map((image, index) => (
            <Avatar
              key={index}
              size={Params.Member.avatar.size}
              image={image}
              tooltip={Params.Member.names[index]}
            />
          ))}
        </MemberAvatarsArea>
      </IntroArea>
      <hr />
      <DetailsArea>
        <Title text={Params.Title.text} size={Params.Title.size} />
        <p>
          <b style={{ color: 'var(--color-2-5)' }}>ReportChecker</b> là một ứng
          dụng chạy đa nền tảng, mạnh mẽ,
          <b style={{ color: 'var(--color-2-5)' }}> bảo mật</b> chạy đồng thời
          song song
          <i style={{ color: 'var(--color-2-4)' }}> nhiều người dùng.</i> Vậy,
          chúng tôi mang lại những tính năng độc đáo gì?
        </p>
        <Separator width={Params.Separator.width} />
        <p style={{ width: '60%', margin: 'auto', textAlign: 'center' }}>
          Phân tích tự động chuỗi kí tự, độ chính xác cao.
        </p>
        <p style={{ width: '80%', margin: 'auto', textAlign: 'center' }}>
          Phân tích dữ liệu từ kho dữ liệu đã lưu trữ, cho người dùng cái nhìn
          khách quan từ các sản phẩm.
        </p>
        <Separator width={Params.Separator.width} />
        {MessageData?.map((item, index) => (
          <div
            key={index}
            style={{
              display: 'flex',
              justifyContent: index % 2 === 0 ? 'flex-start' : 'flex-end'
            }}
          >
            <MessageForm
              width={item.width}
              position={index % 2 === 0 ? 'left' : 'right'}
              avatar={item.avatar}
              name={item.name}
              info={item.info}
              message={item.message}
            />
          </div>
        ))}
        <Separator width={Params.Separator.width} />
        <p style={{ width: '100%', margin: 'auto', textAlign: 'center' }}>
          Cảm ơn các bạn đã sử dụng ứng dụng của chúng tôi, rất mong đồng hành
          lâu dài cùng bạn.
        </p>
        <Separator width={Params.Separator.width} />
        <p style={{ width: '80%', margin: 'auto', textAlign: 'center' }}>
          Mọi phản hồi vui lòng liên hệ qua:
          <br />
          SĐT: 01234567890
          <br />
          Email: reportchecker@gmail.com
        </p>
      </DetailsArea>
    </Wrapper>
  )
}

export default Introduce
