import React from 'react'
import {
  Switch,
  Route,
  useRouteMatch,
  useHistory,
  Redirect
} from 'react-router-dom'
import { Params, ContentData } from './defaultValue'
import { Wrapper, Content } from './elements'
import RadioButton from '../../../components/commons/RadioButton/index'

const Help = () => {
  const { path } = useRouteMatch()
  const history = useHistory()

  const headerData = ContentData.reduce((headerArr, item) => {
    headerArr.push({
      name: item.name,
      value: item.value
    })
    return headerArr
  }, [])

  return (
    <>
      <Redirect from={path} to={path + ContentData?.[0].linkTo} />
      <Wrapper>
        <RadioButton
          data={headerData}
          size={Params.RadioButton.size}
          width={Params.RadioButton.width}
          valueOnChange={value =>
            history.push(
              path + ContentData.find(item => item.value === value).linkTo
            )
          }
        />
        <Content>
          <Switch>
            {ContentData?.map((item, index) => (
              <Route key={index} path={path + item.linkTo}>
                {item.element}
              </Route>
            ))}
          </Switch>
        </Content>
      </Wrapper>
    </>
  )
}

export default Help
