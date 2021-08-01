import React, { useState, useEffect } from 'react'
import { useRouteMatch, useHistory, NavLink } from 'react-router-dom'
import { Button } from './elements'

const ButtonNavbar = ({ text, icon, iconSelected, linkTo }) => {
  const { location } = useHistory()
  const { url } = useRouteMatch()
  const [isActive, setIsActive] = useState(false)

  useEffect(() => {
    setIsActive(prev => (prev = location.pathname === url + linkTo))
  }, [location.pathname, linkTo, url])

  return (
    <Button active={isActive} icon={icon} iconSelected={iconSelected}>
      <NavLink to={`${url}${linkTo}`}>{text}</NavLink>
    </Button>
  )
}

export default ButtonNavbar
