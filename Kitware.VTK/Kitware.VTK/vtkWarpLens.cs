using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWarpLens : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpLens";

		public new static readonly string MRClassNameKey;

		static vtkWarpLens()
		{
			vtkWarpLens.MRClassNameKey = "class vtkWarpLens";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpLens.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpLens"));
		}

		public vtkWarpLens(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpLens_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpLens New()
		{
			vtkWarpLens result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWarpLens() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWarpLens.vtkWarpLens_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpLens_GetCenter_01(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetFormatHeight_02(HandleRef pThis);

		public virtual double GetFormatHeight()
		{
			return vtkWarpLens.vtkWarpLens_GetFormatHeight_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetFormatWidth_03(HandleRef pThis);

		public virtual double GetFormatWidth()
		{
			return vtkWarpLens.vtkWarpLens_GetFormatWidth_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpLens_GetImageHeight_04(HandleRef pThis);

		public virtual int GetImageHeight()
		{
			return vtkWarpLens.vtkWarpLens_GetImageHeight_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpLens_GetImageWidth_05(HandleRef pThis);

		public virtual int GetImageWidth()
		{
			return vtkWarpLens.vtkWarpLens_GetImageWidth_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetK1_06(HandleRef pThis);

		public virtual double GetK1()
		{
			return vtkWarpLens.vtkWarpLens_GetK1_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetK2_07(HandleRef pThis);

		public virtual double GetK2()
		{
			return vtkWarpLens.vtkWarpLens_GetK2_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetKappa_08(HandleRef pThis);

		public double GetKappa()
		{
			return vtkWarpLens.vtkWarpLens_GetKappa_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetP1_09(HandleRef pThis);

		public virtual double GetP1()
		{
			return vtkWarpLens.vtkWarpLens_GetP1_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpLens_GetP2_10(HandleRef pThis);

		public virtual double GetP2()
		{
			return vtkWarpLens.vtkWarpLens_GetP2_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpLens_GetPrincipalPoint_11(HandleRef pThis);

		public virtual double[] GetPrincipalPoint()
		{
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_GetPrincipalPoint_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_GetPrincipalPoint_12(HandleRef pThis, IntPtr data);

		public virtual void GetPrincipalPoint(IntPtr data)
		{
			vtkWarpLens.vtkWarpLens_GetPrincipalPoint_12(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpLens_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWarpLens.vtkWarpLens_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpLens_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWarpLens.vtkWarpLens_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpLens_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWarpLens NewInstance()
		{
			vtkWarpLens result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpLens_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpLens SafeDownCast(vtkObjectBase o)
		{
			vtkWarpLens vtkWarpLens = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpLens = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpLens.Register(null);
				}
			}
			return vtkWarpLens;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetCenter_18(HandleRef pThis, double centerX, double centerY);

		public void SetCenter(double centerX, double centerY)
		{
			vtkWarpLens.vtkWarpLens_SetCenter_18(base.GetCppThis(), centerX, centerY);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetFormatHeight_19(HandleRef pThis, double _arg);

		public virtual void SetFormatHeight(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetFormatHeight_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetFormatWidth_20(HandleRef pThis, double _arg);

		public virtual void SetFormatWidth(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetFormatWidth_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetImageHeight_21(HandleRef pThis, int _arg);

		public virtual void SetImageHeight(int _arg)
		{
			vtkWarpLens.vtkWarpLens_SetImageHeight_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetImageWidth_22(HandleRef pThis, int _arg);

		public virtual void SetImageWidth(int _arg)
		{
			vtkWarpLens.vtkWarpLens_SetImageWidth_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetK1_23(HandleRef pThis, double _arg);

		public virtual void SetK1(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetK1_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetK2_24(HandleRef pThis, double _arg);

		public virtual void SetK2(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetK2_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetKappa_25(HandleRef pThis, double kappa);

		public void SetKappa(double kappa)
		{
			vtkWarpLens.vtkWarpLens_SetKappa_25(base.GetCppThis(), kappa);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetP1_26(HandleRef pThis, double _arg);

		public virtual void SetP1(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetP1_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetP2_27(HandleRef pThis, double _arg);

		public virtual void SetP2(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetP2_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetPrincipalPoint_28(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetPrincipalPoint(double _arg1, double _arg2)
		{
			vtkWarpLens.vtkWarpLens_SetPrincipalPoint_28(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpLens_SetPrincipalPoint_29(HandleRef pThis, IntPtr _arg);

		public void SetPrincipalPoint(IntPtr _arg)
		{
			vtkWarpLens.vtkWarpLens_SetPrincipalPoint_29(base.GetCppThis(), _arg);
		}
	}
}
