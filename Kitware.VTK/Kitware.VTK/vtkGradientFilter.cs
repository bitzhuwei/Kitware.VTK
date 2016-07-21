using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGradientFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGradientFilter";

		public new static readonly string MRClassNameKey;

		static vtkGradientFilter()
		{
			vtkGradientFilter.MRClassNameKey = "class vtkGradientFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGradientFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGradientFilter"));
		}

		public vtkGradientFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGradientFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGradientFilter New()
		{
			vtkGradientFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGradientFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGradientFilter.vtkGradientFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_ComputeVorticityOff_01(HandleRef pThis);

		public virtual void ComputeVorticityOff()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeVorticityOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_ComputeVorticityOn_02(HandleRef pThis);

		public virtual void ComputeVorticityOn()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeVorticityOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_FasterApproximationOff_03(HandleRef pThis);

		public virtual void FasterApproximationOff()
		{
			vtkGradientFilter.vtkGradientFilter_FasterApproximationOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_FasterApproximationOn_04(HandleRef pThis);

		public virtual void FasterApproximationOn()
		{
			vtkGradientFilter.vtkGradientFilter_FasterApproximationOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGradientFilter_GetComputeVorticity_05(HandleRef pThis);

		public virtual int GetComputeVorticity()
		{
			return vtkGradientFilter.vtkGradientFilter_GetComputeVorticity_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGradientFilter_GetFasterApproximation_06(HandleRef pThis);

		public virtual int GetFasterApproximation()
		{
			return vtkGradientFilter.vtkGradientFilter_GetFasterApproximation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGradientFilter_GetResultArrayName_07(HandleRef pThis);

		public virtual string GetResultArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGradientFilter.vtkGradientFilter_GetResultArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGradientFilter_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGradientFilter_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGradientFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGradientFilter NewInstance()
		{
			vtkGradientFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGradientFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGradientFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGradientFilter vtkGradientFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGradientFilter = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGradientFilter.Register(null);
				}
			}
			return vtkGradientFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_SetComputeVorticity_13(HandleRef pThis, int _arg);

		public virtual void SetComputeVorticity(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetComputeVorticity_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_SetFasterApproximation_14(HandleRef pThis, int _arg);

		public virtual void SetFasterApproximation(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetFasterApproximation_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_SetInputScalars_15(HandleRef pThis, int fieldAssociation, string name);

		public virtual void SetInputScalars(int fieldAssociation, string name)
		{
			vtkGradientFilter.vtkGradientFilter_SetInputScalars_15(base.GetCppThis(), fieldAssociation, name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_SetInputScalars_16(HandleRef pThis, int fieldAssociation, int fieldAttributeType);

		public virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
		{
			vtkGradientFilter.vtkGradientFilter_SetInputScalars_16(base.GetCppThis(), fieldAssociation, fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGradientFilter_SetResultArrayName_17(HandleRef pThis, string _arg);

		public virtual void SetResultArrayName(string _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetResultArrayName_17(base.GetCppThis(), _arg);
		}
	}
}
