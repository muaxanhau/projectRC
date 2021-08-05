import React from 'react'
import { Params } from './defaultValue'
import {
  Wrapper,
  IntroArea,
  MemberAvatarsArea,
  Avatar,
  DetailsArea
} from './elements'
import AppLogo from './../../../components/commons/AppLogo/index'
import Title from './../../../components/commons/Title/index'

const Introduce = () => {
  const nameArr = Params.Member.names

  return (
    <Wrapper>
      <IntroArea>
        <AppLogo size={Params.AppLogo.size} />
        <MemberAvatarsArea>
          {Params.Member.avatars.map((avatar, index) => (
            <Avatar key={index} image={avatar} tooltip={nameArr[index]} />
          ))}
        </MemberAvatarsArea>
      </IntroArea>
      <DetailsArea>
        <Title text={Params.Title.text} size={Params.Title.size} />
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati
          eum reprehenderit quae aut illum! Praesentium delectus laboriosam,
          quisquam ad hic soluta distinctio quas doloremque alias vel a harum!
          Dignissimos, corrupti?
        </p>
      </DetailsArea>
    </Wrapper>
  )
}

export default Introduce
