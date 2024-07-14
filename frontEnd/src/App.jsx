import './App.css'

import Footer from './ui/Footer.jsx'
import Menu from './ui/Menu.jsx'

import { AxiosTryGet } from './axios/axiosConfig.jsx'
import { useEffect, useState } from 'react'

function App() {

  const [MemaData, setMemaData] = useState(null)

  const getMemaData = async()=>{
    await AxiosTryGet.get()
      .then((res)=>{
        setMemaData(res.data)
        console.log(res.data)
      })
      .catch(
        console.log('hinde gumagana ssob')
      )
  }

  useEffect(()=>{
    getMemaData()
    console.log(MemaData)
  },[])

  return (
    <>
      <div>
        <Menu/>
        <Footer/>
        
      </div>
    </>
  )
}

export default App
