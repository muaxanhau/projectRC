import React from 'react'
import Images from './../../../constants/Images'
import { Container, Wrapper, Content, Image, TextArea } from './elements'
import Title from './../../../components/commons/Title/index'
import Separator from './../../../components/commons/Separator/index'

const Guild = () => {
  return (
    <Container>
      <Wrapper>
        <Title text='Giao diện' />
        <Separator width='10%' />
        <Content>
          <Image src={Images.GUILD_IMAGES.NO_1} />
          <TextArea>
            <p>1. Lorem ipsum dolor sit amet</p>
            <p>
              2. eum reprehenderit <b>quae aut</b> illum!
            </p>
            <p>3. quisquam ad hic soluta</p>
            <p>
              4. vel a <u>harum!</u> Dignissimos
            </p>
            <p>5. soluta distinctio quas doloremque</p>
          </TextArea>
        </Content>
        <hr />
        <Content>
          <Image src={Images.GUILD_IMAGES.NO_1} />
          <TextArea>
            <h3>Lorem ipsum dolor sit amet</h3>
            <p>
              Lorem ipsum dolor sit amet, consectetur adipisicing elit.
              Obcaecati eum reprehenderit quae aut illum! Praesentium delectus
              laboriosam, quisquam ad hic soluta distinctio quas doloremque
              alias vel a harum! Dignissimos, corrupti?
            </p>
          </TextArea>
        </Content>
      </Wrapper>
      <Wrapper>
        <Title text='Sử dụng' />
        <Separator width='10%' />
        <Content>
          <Image src={Images.GUILD_IMAGES.NO_1} />
          <TextArea>
            <p>1. Lorem ipsum dolor sit amet</p>
            <p>
              2. eum reprehenderit <b>quae aut</b> illum!
            </p>
            <p>3. quisquam ad hic soluta</p>
            <p>
              4. vel a <u>harum!</u> Dignissimos
            </p>
            <p>5. soluta distinctio quas doloremque</p>
            <hr />
            <p>
              Lorem ipsum dolor sit amet, consectetur adipisicing elit.
              Obcaecati eum reprehenderit quae aut illum! Praesentium delectus
              laboriosam, quisquam ad hic soluta distinctio quas doloremque
              alias vel a harum! Dignissimos, corrupti?
            </p>
            <hr />
            <p>1. Lorem ipsum dolor sit amet</p>
            <p>
              2. eum reprehenderit <b>quae aut</b> illum!
            </p>
          </TextArea>
        </Content>
      </Wrapper>
    </Container>
  )
}

export default Guild
