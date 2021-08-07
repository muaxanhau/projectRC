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
          <b style={{ color: 'var(--color-2-5)' }}>Lorem</b> ipsum dolor sit
          amet, consectetur adipisicing elit. Obcaecati aut{' '}
          <b style={{ color: 'var(--color-2-5)' }}>illum!</b> Praesentium
          delectus laboriosam,
          <i style={{ color: 'var(--color-2-4)' }}> quisquam</i> ad hic soluta
          distinctio quas <u>doloremque</u> alias vel a harum! Dignissimos,
          corrupti?
        </p>
        <Separator width={Params.Separator.width} />
        <p style={{ width: '60%', margin: 'auto', textAlign: 'center' }}>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum
        </p>
        <p style={{ width: '80%', margin: 'auto', textAlign: 'center' }}>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum
        </p>
        <Separator width={Params.Separator.width} />
        {MessageData.map((item, index) => (
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
        <p>
          <b style={{ color: 'var(--color-2-5)' }}>Lorem</b> ipsum dolor sit
          amet, consectetur adipisicing elit. Obcaecati aut{' '}
          <b style={{ color: 'var(--color-2-5)' }}>illum!</b> Praesentium
          delectus laboriosam,
          <i style={{ color: 'var(--color-2-4)' }}> quisquam</i> ad hic soluta
          distinctio quas <u>doloremque</u> alias vel a harum! Dignissimos,
          corrupti?
        </p>
        <Separator width={Params.Separator.width} />
        <p style={{ width: '60%', margin: 'auto', textAlign: 'center' }}>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum
        </p>
      </DetailsArea>
    </Wrapper>
  )
}

export default Introduce
