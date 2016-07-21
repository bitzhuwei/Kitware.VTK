using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLineSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineSource";

		public new static readonly string MRClassNameKey;

		static vtkLineSource()
		{
			vtkLineSource.MRClassNameKey = "class vtkLineSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineSource"));
		}

		public vtkLineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineSource New()
		{
			vtkLineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineSource.vtkLineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLineSource.vtkLineSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLineSource_GetPoint1_01(HandleRef pThis);

		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkLineSource.vtkLineSource_GetPoint1_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_GetPoint1_02(HandleRef pThis, IntPtr data);

		public virtual void GetPoint1(IntPtr data)
		{
			vtkLineSource.vtkLineSource_GetPoint1_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLineSource_GetPoint2_03(HandleRef pThis);

		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkLineSource.vtkLineSource_GetPoint2_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_GetPoint2_04(HandleRef pThis, IntPtr data);

		public virtual void GetPoint2(IntPtr data)
		{
			vtkLineSource.vtkLineSource_GetPoint2_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLineSource_GetResolution_05(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkLineSource.vtkLineSource_GetResolution_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLineSource_GetResolutionMaxValue_06(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkLineSource.vtkLineSource_GetResolutionMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLineSource_GetResolutionMinValue_07(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkLineSource.vtkLineSource_GetResolutionMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLineSource_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLineSource.vtkLineSource_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLineSource_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLineSource.vtkLineSource_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLineSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLineSource NewInstance()
		{
			vtkLineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineSource.vtkLineSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLineSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineSource SafeDownCast(vtkObjectBase o)
		{
			vtkLineSource vtkLineSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineSource.vtkLineSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineSource = (vtkLineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineSource.Register(null);
				}
			}
			return vtkLineSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_SetPoint1_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkLineSource.vtkLineSource_SetPoint1_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_SetPoint1_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkLineSource.vtkLineSource_SetPoint1_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_SetPoint2_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkLineSource.vtkLineSource_SetPoint2_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_SetPoint2_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkLineSource.vtkLineSource_SetPoint2_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkLineSource_SetResolution_17(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkLineSource.vtkLineSource_SetResolution_17(base.GetCppThis(), _arg);
		}
	}
}
