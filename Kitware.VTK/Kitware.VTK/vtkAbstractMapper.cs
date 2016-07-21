using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAbstractMapper : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper";

		public new static readonly string MRClassNameKey;

		static vtkAbstractMapper()
		{
			vtkAbstractMapper.MRClassNameKey = "class vtkAbstractMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper"));
		}

		public vtkAbstractMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_AddClippingPlane_01(HandleRef pThis, HandleRef plane);

		public void AddClippingPlane(vtkPlane plane)
		{
			vtkAbstractMapper.vtkAbstractMapper_AddClippingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper_GetClippingPlanes_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlaneCollection GetClippingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetClippingPlanes_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkAbstractMapper_GetMTime_03(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetMTime_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper_GetScalars_04(HandleRef input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataArray GetScalars(vtkDataSet input, int scalarMode, int arrayAccessMode, int arrayId, string arrayName, ref int cellFlag)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_GetScalars_04((input == null) ? default(HandleRef) : input.GetCppThis(), scalarMode, arrayAccessMode, arrayId, arrayName, ref cellFlag, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAbstractMapper_GetTimeToDraw_05(HandleRef pThis);

		public virtual double GetTimeToDraw()
		{
			return vtkAbstractMapper.vtkAbstractMapper_GetTimeToDraw_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractMapper_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractMapper.vtkAbstractMapper_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractMapper NewInstance()
		{
			vtkAbstractMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractMapper.vtkAbstractMapper_ReleaseGraphicsResources_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_RemoveAllClippingPlanes_10(HandleRef pThis);

		public void RemoveAllClippingPlanes()
		{
			vtkAbstractMapper.vtkAbstractMapper_RemoveAllClippingPlanes_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_RemoveClippingPlane_11(HandleRef pThis, HandleRef plane);

		public void RemoveClippingPlane(vtkPlane plane)
		{
			vtkAbstractMapper.vtkAbstractMapper_RemoveClippingPlane_11(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractMapper SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractMapper vtkAbstractMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractMapper.vtkAbstractMapper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper = (vtkAbstractMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper.Register(null);
				}
			}
			return vtkAbstractMapper;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_SetClippingPlanes_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetClippingPlanes(vtkPlaneCollection arg0)
		{
			vtkAbstractMapper.vtkAbstractMapper_SetClippingPlanes_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_SetClippingPlanes_14(HandleRef pThis, HandleRef planes);

		public void SetClippingPlanes(vtkPlanes planes)
		{
			vtkAbstractMapper.vtkAbstractMapper_SetClippingPlanes_14(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractMapper_ShallowCopy_15(HandleRef pThis, HandleRef m);

		public void ShallowCopy(vtkAbstractMapper m)
		{
			vtkAbstractMapper.vtkAbstractMapper_ShallowCopy_15(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}
	}
}
