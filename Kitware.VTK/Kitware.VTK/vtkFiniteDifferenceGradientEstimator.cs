using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFiniteDifferenceGradientEstimator : vtkEncodedGradientEstimator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFiniteDifferenceGradientEstimator";

		public new static readonly string MRClassNameKey;

		static vtkFiniteDifferenceGradientEstimator()
		{
			vtkFiniteDifferenceGradientEstimator.MRClassNameKey = "class vtkFiniteDifferenceGradientEstimator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFiniteDifferenceGradientEstimator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiniteDifferenceGradientEstimator"));
		}

		public vtkFiniteDifferenceGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFiniteDifferenceGradientEstimator New()
		{
			vtkFiniteDifferenceGradientEstimator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFiniteDifferenceGradientEstimator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_01(HandleRef pThis);

		public virtual int GetSampleSpacingInVoxels()
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFiniteDifferenceGradientEstimator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFiniteDifferenceGradientEstimator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFiniteDifferenceGradientEstimator NewInstance()
		{
			vtkFiniteDifferenceGradientEstimator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFiniteDifferenceGradientEstimator SafeDownCast(vtkObjectBase o)
		{
			vtkFiniteDifferenceGradientEstimator vtkFiniteDifferenceGradientEstimator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFiniteDifferenceGradientEstimator = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFiniteDifferenceGradientEstimator.Register(null);
				}
			}
			return vtkFiniteDifferenceGradientEstimator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_07(HandleRef pThis, int _arg);

		public virtual void SetSampleSpacingInVoxels(int _arg)
		{
			vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_07(base.GetCppThis(), _arg);
		}
	}
}
