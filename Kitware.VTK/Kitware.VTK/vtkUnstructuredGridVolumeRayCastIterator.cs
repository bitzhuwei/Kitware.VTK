using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkUnstructuredGridVolumeRayCastIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeRayCastIterator()
		{
			vtkUnstructuredGridVolumeRayCastIterator.MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator"));
		}

		public vtkUnstructuredGridVolumeRayCastIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetBounds(ref double _arg1, ref double _arg2)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetBounds(IntPtr _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(HandleRef pThis);

		public virtual long GetMaxNumberOfIntersections()
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(HandleRef pThis, HandleRef intersectedCells, HandleRef intersectionLengths, HandleRef scalars, HandleRef nearIntersections, HandleRef farIntersections);

		public virtual long GetNextIntersections(vtkIdList intersectedCells, vtkDoubleArray intersectionLengths, vtkDataArray scalars, vtkDataArray nearIntersections, vtkDataArray farIntersections)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(base.GetCppThis(), (intersectedCells == null) ? default(HandleRef) : intersectedCells.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_Initialize_06(HandleRef pThis, int x, int y);

		public virtual void Initialize(int x, int y)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_Initialize_06(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeRayCastIterator NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeRayCastIterator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_11(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetBounds(double _arg1, double _arg2)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetBounds_11(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_12(HandleRef pThis, IntPtr _arg);

		public void SetBounds(IntPtr _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetBounds_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_13(HandleRef pThis, long _arg);

		public virtual void SetMaxNumberOfIntersections(long _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_13(base.GetCppThis(), _arg);
		}
	}
}
