import React from 'react'
import { Params } from './defaulltValue'
import { Container, InfoArea, Info, ContentArea } from './element'
import Avatar from './../Avatar/index'
import MessageBox from './../MessageBox/index'

const MessageForm = ({
  width,
  position = 'left',
  avatar,
  name,
  info,
  message
}) => {
  return (
    <Container width={width}>
      <InfoArea position={position}>
        <Avatar image={avatar} size={Params.Avatar.size} />
        <Info>
          <h4>{name}</h4>
          <p>{info}</p>
        </Info>
      </InfoArea>
      <ContentArea
        padding={
          Params.Avatar.size === 'large'
            ? 'calc(var(--img-size-medium) / 2)'
            : 'calc(var(--img-size-medium) * 0.7 / 2)'
        }
      >
        <MessageBox width='100%' arrowPosition={position}>
          {message}
        </MessageBox>
      </ContentArea>
    </Container>
  )
}

export default MessageForm
