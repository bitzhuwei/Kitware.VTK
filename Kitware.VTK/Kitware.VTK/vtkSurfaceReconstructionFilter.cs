using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSurfaceReconstructionFilter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceReconstructionFilter";

		public new static readonly string MRClassNameKey;

		static vtkSurfaceReconstructionFilter()
		{
			vtkSurfaceReconstructionFilter.MRClassNameKey = "class vtkSurfaceReconstructionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceReconstructionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceReconstructionFilter"));
		}

		public vtkSurfaceReconstructionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceReconstructionFilter New()
		{
			vtkSurfaceReconstructionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSurfaceReconstructionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(HandleRef pThis);

		public virtual int GetNeighborhoodSize()
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetNeighborhoodSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkSurfaceReconstructionFilter_GetSampleSpacing_02(HandleRef pThis);

		public virtual double GetSampleSpacing()
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_GetSampleSpacing_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSurfaceReconstructionFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkSurfaceReconstructionFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSurfaceReconstructionFilter NewInstance()
		{
			vtkSurfaceReconstructionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceReconstructionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceReconstructionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceReconstructionFilter vtkSurfaceReconstructionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceReconstructionFilter = (vtkSurfaceReconstructionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceReconstructionFilter.Register(null);
				}
			}
			return vtkSurfaceReconstructionFilter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSurfaceReconstructionFilter_SetNeighborhoodSize_08(HandleRef pThis, int _arg);

		public virtual void SetNeighborhoodSize(int _arg)
		{
			vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SetNeighborhoodSize_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkSurfaceReconstructionFilter_SetSampleSpacing_09(HandleRef pThis, double _arg);

		public virtual void SetSampleSpacing(double _arg)
		{
			vtkSurfaceReconstructionFilter.vtkSurfaceReconstructionFilter_SetSampleSpacing_09(base.GetCppThis(), _arg);
		}
	}
}
