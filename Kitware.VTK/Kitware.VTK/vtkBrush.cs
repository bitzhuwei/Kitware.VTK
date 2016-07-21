using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBrush : vtkObject
	{
		public enum TextureProperty
		{
			Linear = 2,
			Nearest = 1,
			Repeat = 8,
			Stretch = 4
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBrush";

		public new static readonly string MRClassNameKey;

		static vtkBrush()
		{
			vtkBrush.MRClassNameKey = "class vtkBrush";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBrush.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrush"));
		}

		public vtkBrush(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBrush_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBrush New()
		{
			vtkBrush result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrush.vtkBrush_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBrush() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBrush.vtkBrush_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_DeepCopy_01(HandleRef pThis, HandleRef brush);

		public void DeepCopy(vtkBrush brush)
		{
			vtkBrush.vtkBrush_DeepCopy_01(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_GetColor_02(HandleRef pThis, IntPtr color);

		public void GetColor(IntPtr color)
		{
			vtkBrush.vtkBrush_GetColor_02(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBrush_GetColor_03(HandleRef pThis);

		public IntPtr GetColor()
		{
			return vtkBrush.vtkBrush_GetColor_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_GetColorF_04(HandleRef pThis, IntPtr color);

		public void GetColorF(IntPtr color)
		{
			vtkBrush.vtkBrush_GetColorF_04(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBrush_GetTexture_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetTexture()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrush.vtkBrush_GetTexture_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkBrush_GetTextureProperties_06(HandleRef pThis);

		public virtual int GetTextureProperties()
		{
			return vtkBrush.vtkBrush_GetTextureProperties_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkBrush_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBrush.vtkBrush_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkBrush_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBrush.vtkBrush_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBrush_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBrush NewInstance()
		{
			vtkBrush result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrush.vtkBrush_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkBrush_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBrush SafeDownCast(vtkObjectBase o)
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBrush.vtkBrush_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColor_12(HandleRef pThis, IntPtr color);

		public void SetColor(IntPtr color)
		{
			vtkBrush.vtkBrush_SetColor_12(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColor_13(HandleRef pThis, byte r, byte g, byte b);

		public void SetColor(byte r, byte g, byte b)
		{
			vtkBrush.vtkBrush_SetColor_13(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColor_14(HandleRef pThis, byte r, byte g, byte b, byte a);

		public void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkBrush.vtkBrush_SetColor_14(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColorF_15(HandleRef pThis, IntPtr color);

		public void SetColorF(IntPtr color)
		{
			vtkBrush.vtkBrush_SetColorF_15(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColorF_16(HandleRef pThis, double r, double g, double b);

		public void SetColorF(double r, double g, double b)
		{
			vtkBrush.vtkBrush_SetColorF_16(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetColorF_17(HandleRef pThis, double r, double g, double b, double a);

		public void SetColorF(double r, double g, double b, double a)
		{
			vtkBrush.vtkBrush_SetColorF_17(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetOpacity_18(HandleRef pThis, byte a);

		public void SetOpacity(byte a)
		{
			vtkBrush.vtkBrush_SetOpacity_18(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetOpacityF_19(HandleRef pThis, double a);

		public void SetOpacityF(double a)
		{
			vtkBrush.vtkBrush_SetOpacityF_19(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetTexture_20(HandleRef pThis, HandleRef image);

		public void SetTexture(vtkImageData image)
		{
			vtkBrush.vtkBrush_SetTexture_20(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkBrush_SetTextureProperties_21(HandleRef pThis, int _arg);

		public virtual void SetTextureProperties(int _arg)
		{
			vtkBrush.vtkBrush_SetTextureProperties_21(base.GetCppThis(), _arg);
		}
	}
}
