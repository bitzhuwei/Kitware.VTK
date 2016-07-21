using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPen : vtkObject
	{
		public enum DASH_DOT_DOT_LINE_WrapperEnum
		{
			DASH_DOT_DOT_LINE = 5,
			DASH_DOT_LINE = 4,
			DASH_LINE = 2,
			DOT_LINE,
			NO_PEN = 0,
			SOLID_LINE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPen";

		public new static readonly string MRClassNameKey;

		static vtkPen()
		{
			vtkPen.MRClassNameKey = "class vtkPen";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPen.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPen"));
		}

		public vtkPen(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPen_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPen New()
		{
			vtkPen result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPen.vtkPen_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPen() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPen.vtkPen_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_DeepCopy_01(HandleRef pThis, HandleRef pen);

		public void DeepCopy(vtkPen pen)
		{
			vtkPen.vtkPen_DeepCopy_01(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_GetColor_02(HandleRef pThis, IntPtr color);

		public void GetColor(IntPtr color)
		{
			vtkPen.vtkPen_GetColor_02(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPen_GetColor_03(HandleRef pThis);

		public IntPtr GetColor()
		{
			return vtkPen.vtkPen_GetColor_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_GetColorF_04(HandleRef pThis, IntPtr color);

		public void GetColorF(IntPtr color)
		{
			vtkPen.vtkPen_GetColorF_04(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPen_GetLineType_05(HandleRef pThis);

		public int GetLineType()
		{
			return vtkPen.vtkPen_GetLineType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPen_GetOpacity_06(HandleRef pThis);

		public byte GetOpacity()
		{
			return vtkPen.vtkPen_GetOpacity_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern float vtkPen_GetWidth_07(HandleRef pThis);

		public virtual float GetWidth()
		{
			return vtkPen.vtkPen_GetWidth_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPen_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPen.vtkPen_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPen_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPen.vtkPen_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPen_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPen NewInstance()
		{
			vtkPen result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPen.vtkPen_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPen_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPen SafeDownCast(vtkObjectBase o)
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPen.vtkPen_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColor_13(HandleRef pThis, IntPtr color);

		public void SetColor(IntPtr color)
		{
			vtkPen.vtkPen_SetColor_13(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColor_14(HandleRef pThis, byte r, byte g, byte b);

		public void SetColor(byte r, byte g, byte b)
		{
			vtkPen.vtkPen_SetColor_14(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColor_15(HandleRef pThis, byte r, byte g, byte b, byte a);

		public void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPen.vtkPen_SetColor_15(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColorF_16(HandleRef pThis, IntPtr color);

		public void SetColorF(IntPtr color)
		{
			vtkPen.vtkPen_SetColorF_16(base.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColorF_17(HandleRef pThis, double r, double g, double b);

		public void SetColorF(double r, double g, double b)
		{
			vtkPen.vtkPen_SetColorF_17(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetColorF_18(HandleRef pThis, double r, double g, double b, double a);

		public void SetColorF(double r, double g, double b, double a)
		{
			vtkPen.vtkPen_SetColorF_18(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetLineType_19(HandleRef pThis, int type);

		public void SetLineType(int type)
		{
			vtkPen.vtkPen_SetLineType_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetOpacity_20(HandleRef pThis, byte a);

		public void SetOpacity(byte a)
		{
			vtkPen.vtkPen_SetOpacity_20(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetOpacityF_21(HandleRef pThis, double a);

		public void SetOpacityF(double a)
		{
			vtkPen.vtkPen_SetOpacityF_21(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPen_SetWidth_22(HandleRef pThis, float _arg);

		public virtual void SetWidth(float _arg)
		{
			vtkPen.vtkPen_SetWidth_22(base.GetCppThis(), _arg);
		}
	}
}
