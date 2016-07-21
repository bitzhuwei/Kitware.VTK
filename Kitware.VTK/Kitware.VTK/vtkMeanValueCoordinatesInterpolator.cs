using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMeanValueCoordinatesInterpolator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMeanValueCoordinatesInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkMeanValueCoordinatesInterpolator()
		{
			vtkMeanValueCoordinatesInterpolator.MRClassNameKey = "class vtkMeanValueCoordinatesInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMeanValueCoordinatesInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeanValueCoordinatesInterpolator"));
		}

		public vtkMeanValueCoordinatesInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMeanValueCoordinatesInterpolator New()
		{
			vtkMeanValueCoordinatesInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMeanValueCoordinatesInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

		public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkIdList tris, IntPtr weights)
		{
			vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_01(x, (pts == null) ? default(HandleRef) : pts.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(IntPtr x, HandleRef pts, HandleRef tris, IntPtr weights);

		public static void ComputeInterpolationWeights(IntPtr x, vtkPoints pts, vtkCellArray tris, IntPtr weights)
		{
			vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_ComputeInterpolationWeights_02(x, (pts == null) ? default(HandleRef) : pts.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMeanValueCoordinatesInterpolator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMeanValueCoordinatesInterpolator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMeanValueCoordinatesInterpolator NewInstance()
		{
			vtkMeanValueCoordinatesInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMeanValueCoordinatesInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMeanValueCoordinatesInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkMeanValueCoordinatesInterpolator vtkMeanValueCoordinatesInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMeanValueCoordinatesInterpolator.vtkMeanValueCoordinatesInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMeanValueCoordinatesInterpolator = (vtkMeanValueCoordinatesInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMeanValueCoordinatesInterpolator.Register(null);
				}
			}
			return vtkMeanValueCoordinatesInterpolator;
		}
	}
}
