import React from 'react'
import { Wrapper } from './elements'
import ButtonNavbar from './../commons/ButtonNavbar/index'

const Navbar = ({ data = [], width }) => {
  return (
    <Wrapper width={width}>
      {data?.map((item, index) => (
        <ButtonNavbar
          key={index}
          text={item.name}
          icon={item.icon.normal}
          iconSelected={item.icon.selected}
          linkTo={item.linkTo}
        />
      ))}
    </Wrapper>
  )
}

export default Navbar
