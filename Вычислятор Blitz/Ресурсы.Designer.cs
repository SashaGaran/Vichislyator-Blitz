namespace Вычислятор_Blitz
{
	using System;
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	class Ресурсы
	{
		static global::System.Resources.ResourceManager resourceMan;
		static global::System.Globalization.CultureInfo resourceCulture;
		internal Ресурсы() {}
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager {
			get {
				if (object.ReferenceEquals(resourceMan, null)) {
					var temp = new global::System.Resources.ResourceManager("Вычислятор_Blitz.Ресурсы", typeof(Ресурсы).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture {
			get {return resourceCulture;}
			set {resourceCulture = value;}
		}
		internal static System.Drawing.Bitmap Золото {
			get {
				object obj = ResourceManager.GetObject("Золото", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}
		internal static System.Drawing.Icon Иконка {
			get {
				object obj = ResourceManager.GetObject("Иконка", resourceCulture);
				return ((System.Drawing.Icon)(obj));
			}
		}
		internal static System.Drawing.Bitmap Опыт {
			get {
				object obj = ResourceManager.GetObject("Опыт", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}
		internal static System.Drawing.Bitmap Серебро {
			get {
				object obj = ResourceManager.GetObject("Серебро", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}
		internal static System.Drawing.Bitmap Стрелочка {
			get {
				object obj = ResourceManager.GetObject("Стрелочка", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}
	}
}