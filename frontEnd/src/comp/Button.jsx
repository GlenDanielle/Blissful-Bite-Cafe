import '../assets/css/Button.css'

const Button = ({Data, Txt}) => {
  return (
    <div>
      <button className={Data}>
        {Txt}
      </button>
    </div>
  )
}

export default Button