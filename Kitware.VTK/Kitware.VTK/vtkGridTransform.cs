using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGridTransform : vtkWarpTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGridTransform";

		public new static readonly string MRClassNameKey;

		static vtkGridTransform()
		{
			vtkGridTransform.MRClassNameKey = "class vtkGridTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGridTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridTransform"));
		}

		public vtkGridTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGridTransform New()
		{
			vtkGridTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGridTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGridTransform.vtkGridTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_GetDisplacementGrid_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetDisplacementGrid()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_GetDisplacementGrid_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGridTransform_GetDisplacementScale_02(HandleRef pThis);

		public virtual double GetDisplacementScale()
		{
			return vtkGridTransform.vtkGridTransform_GetDisplacementScale_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkGridTransform_GetDisplacementShift_03(HandleRef pThis);

		public virtual double GetDisplacementShift()
		{
			return vtkGridTransform.vtkGridTransform_GetDisplacementShift_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGridTransform_GetInterpolationMode_04(HandleRef pThis);

		public virtual int GetInterpolationMode()
		{
			return vtkGridTransform.vtkGridTransform_GetInterpolationMode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_GetInterpolationModeAsString_05(HandleRef pThis);

		public string GetInterpolationModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGridTransform.vtkGridTransform_GetInterpolationModeAsString_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkGridTransform_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGridTransform.vtkGridTransform_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGridTransform_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGridTransform.vtkGridTransform_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkGridTransform_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGridTransform.vtkGridTransform_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_MakeTransform_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGridTransform NewInstance()
		{
			vtkGridTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkGridTransform_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGridTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGridTransform vtkGridTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridTransform.vtkGridTransform_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGridTransform = (vtkGridTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGridTransform.Register(null);
				}
			}
			return vtkGridTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetDisplacementGrid_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetDisplacementGrid(vtkImageData arg0)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementGrid_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetDisplacementScale_14(HandleRef pThis, double _arg);

		public virtual void SetDisplacementScale(double _arg)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementScale_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetDisplacementShift_15(HandleRef pThis, double _arg);

		public virtual void SetDisplacementShift(double _arg)
		{
			vtkGridTransform.vtkGridTransform_SetDisplacementShift_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetInterpolationMode_16(HandleRef pThis, int mode);

		public void SetInterpolationMode(int mode)
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationMode_16(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetInterpolationModeToCubic_17(HandleRef pThis);

		public void SetInterpolationModeToCubic()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToCubic_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetInterpolationModeToLinear_18(HandleRef pThis);

		public void SetInterpolationModeToLinear()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToLinear_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkGridTransform_SetInterpolationModeToNearestNeighbor_19(HandleRef pThis);

		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkGridTransform.vtkGridTransform_SetInterpolationModeToNearestNeighbor_19(base.GetCppThis());
		}
	}
}
