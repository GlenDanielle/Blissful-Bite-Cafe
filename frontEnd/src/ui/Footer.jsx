import '../assets/css/Footer.css'

import SocialMediaData from '../data/SocialMedia.json'

import Images from '../comp/Images.jsx'
import Icons from '../comp/Icons.jsx'
import Button from '../comp/Button.jsx'

const Footer = () => {
    const ButtonFooterData = ['About us', 'FooterButton']

  return (
    <div className='FooterContainer'>
        <div className='FooterComp'>

            <div className='BannerContainer'>
                <div className='BannerImgContainer'>
                    <img className='BannerImg' src={Images[0].src} alt='banner'></img>
                </div>
                
                <p>
                    "blissful bite cafe, where every bite is a delight"
                </p>

            </div>

            <hr></hr>

            <div className='SocialsContainer'>
                <div>
                    <div className='AboutUsButtonContainer'>
                        <Button Txt={ButtonFooterData[0]} Data={ButtonFooterData[1]}/>
                    </div>
                    <div className='SocialMediaIconContainer'>
                        <p>Contact us:</p>
                        <Icons Data={SocialMediaData}/>
                    </div>
                    <div className='CopyrightContainer'>
                        <svg className='CopyrightLogo' viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg"><g id="SVGRepo_bgCarrier" strokeWidth="0"></g><g id="SVGRepo_tracerCarrier" strokeLinecap="round" strokeLinejoin="round"></g><g id="SVGRepo_iconCarrier"> <path d="M14 9C13.5197 8.40081 12.93 8 12 8C10.0769 8 9 9.14286 9 12C9 14.8571 10.0769 16 12 16C12.93 16 13.5197 15.5992 14 15M12 21C16.9706 21 21 16.9706 21 12C21 7.02944 16.9706 3 12 3C7.02944 3 3 7.02944 3 12C3 16.9706 7.02944 21 12 21Z" stroke="#ffffff" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round"></path> </g></svg>
                        <p>Blissfull Bite Cafe | 2024</p>
                    </div>
                </div>
            </div>

        </div>
    </div>
  ) 
}
export default Footer