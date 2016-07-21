using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoProjectionSource : vtkGeoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoProjectionSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoProjectionSource()
		{
			vtkGeoProjectionSource.MRClassNameKey = "class vtkGeoProjectionSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoProjectionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoProjectionSource"));
		}

		public vtkGeoProjectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoProjectionSource New()
		{
			vtkGeoProjectionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjectionSource.vtkGeoProjectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoProjectionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoProjectionSource.vtkGeoProjectionSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoProjectionSource_FetchChild_01(HandleRef pThis, HandleRef node, int index, HandleRef child);

		public override bool FetchChild(vtkGeoTreeNode node, int index, vtkGeoTreeNode child)
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_FetchChild_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoProjectionSource_FetchRoot_02(HandleRef pThis, HandleRef root);

		public override bool FetchRoot(vtkGeoTreeNode root)
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_FetchRoot_02(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjectionSource_GetMinCellsPerNode_03(HandleRef pThis);

		public virtual int GetMinCellsPerNode()
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_GetMinCellsPerNode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjectionSource_GetProjection_04(HandleRef pThis);

		public virtual int GetProjection()
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_GetProjection_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjectionSource_GetTransform_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjectionSource.vtkGeoProjectionSource_GetTransform_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjectionSource_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoProjectionSource_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoProjectionSource.vtkGeoProjectionSource_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjectionSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoProjectionSource NewInstance()
		{
			vtkGeoProjectionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjectionSource.vtkGeoProjectionSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoProjectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoProjectionSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoProjectionSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoProjectionSource vtkGeoProjectionSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoProjectionSource.vtkGeoProjectionSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoProjectionSource = (vtkGeoProjectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoProjectionSource.Register(null);
				}
			}
			return vtkGeoProjectionSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoProjectionSource_SetMinCellsPerNode_11(HandleRef pThis, int _arg);

		public virtual void SetMinCellsPerNode(int _arg)
		{
			vtkGeoProjectionSource.vtkGeoProjectionSource_SetMinCellsPerNode_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoProjectionSource_SetProjection_12(HandleRef pThis, int projection);

		public virtual void SetProjection(int projection)
		{
			vtkGeoProjectionSource.vtkGeoProjectionSource_SetProjection_12(base.GetCppThis(), projection);
		}
	}
}
