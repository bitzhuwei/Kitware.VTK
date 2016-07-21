using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeAlgorithm()
		{
			vtkHyperOctreeAlgorithm.MRClassNameKey = "class vtkHyperOctreeAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeAlgorithm"));
		}

		public vtkHyperOctreeAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeAlgorithm_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeAlgorithm_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_GetHyperOctreeInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHyperOctree GetHyperOctreeInput(int port)
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_GetHyperOctreeInput_03(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_GetInput_05(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_GetInput_05(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHyperOctree GetOutput()
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_GetOutput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_GetOutput_07(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHyperOctree GetOutput(int arg0)
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_GetOutput_07(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeAlgorithm_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeAlgorithm_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeAlgorithm NewInstance()
		{
			vtkHyperOctreeAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeAlgorithm_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeAlgorithm vtkHyperOctreeAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeAlgorithm = (vtkHyperOctreeAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeAlgorithm.Register(null);
				}
			}
			return vtkHyperOctreeAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeAlgorithm_SetInput_12(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_SetInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeAlgorithm_SetInput_13(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_SetInput_13(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeAlgorithm_SetOutput_14(HandleRef pThis, HandleRef d);

		public virtual void SetOutput(vtkDataObject d)
		{
			vtkHyperOctreeAlgorithm.vtkHyperOctreeAlgorithm_SetOutput_14(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}
	}
}
