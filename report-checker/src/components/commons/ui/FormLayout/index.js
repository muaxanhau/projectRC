import React from 'react'
import { Params } from './defaultValue'
import { Container, Wrapper, Content, Main, ButtonArea } from './elements'
import Title from './../../Title/index'
import ButtonNormal from './../../ButtonNormal/index'

const FormLayout = ({
  title,
  width,
  textButton1,
  textButton2,
  button1Handle,
  button2Handle,
  children
}) => {
  return (
    <Container>
      <Wrapper width={width}>
        <Content>
          {title && (
            <Title
              text={title}
              size={Params.Title.size}
              type={Params.Title.type}
            />
          )}
          <Main>{children}</Main>
        </Content>
        <ButtonArea>
          <ButtonNormal
            text={textButton1 ?? Params.Button.nameDefault[0]}
            size={Params.Button.size}
            width={Params.Button.width}
            onClick={() => button1Handle?.()}
          />
          <ButtonNormal
            text={textButton2 ?? Params.Button.nameDefault[1]}
            size={Params.Button.size}
            width={Params.Button.width}
            onClick={() => button2Handle?.()}
          />
        </ButtonArea>
      </Wrapper>
    </Container>
  )
}

export default FormLayout
