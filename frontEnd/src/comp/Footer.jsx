import './css/Footer.css'
import banner from '/assets/banner.png'

const Footer = () => {
  return (
    <div className='FooterContainer'>
        <div className='FooterComp'>
            <div className='TaglineContainer'>
                <div className='BannerContainer'>
                    <img className='BannerImg' src={banner} alt='banner'/>
                </div>
                <p className='Tagline'>
                    blissful bite cafe, where every bite is a delight
                </p>
            </div>
            <div className='AboutUs'>
                
            </div>
            <div className='SocialMedia'>
                
            </div>
        </div>
    </div>
  )
}

export default Footer