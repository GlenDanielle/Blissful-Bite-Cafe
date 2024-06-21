import '../assets/css/Icons.css'

const Icons = ({Data}) => {
  return (
    <div className={Data[0].group}>
        {Data.map((elem, index) => (
            <div key={index}>
                <img src={elem.icon} alt={elem.name} />
            </div>
        ))}
    </div>
  )
}

export default Icons