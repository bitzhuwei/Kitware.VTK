using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphEdge : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphEdge";

		public new static readonly string MRClassNameKey;

		static vtkGraphEdge()
		{
			vtkGraphEdge.MRClassNameKey = "class vtkGraphEdge";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphEdge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphEdge"));
		}

		public vtkGraphEdge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphEdge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphEdge New()
		{
			vtkGraphEdge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphEdge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphEdge.vtkGraphEdge_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraphEdge_GetId_01(HandleRef pThis);

		public virtual long GetId()
		{
			return vtkGraphEdge.vtkGraphEdge_GetId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraphEdge_GetSource_02(HandleRef pThis);

		public virtual long GetSource()
		{
			return vtkGraphEdge.vtkGraphEdge_GetSource_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraphEdge_GetTarget_03(HandleRef pThis);

		public virtual long GetTarget()
		{
			return vtkGraphEdge.vtkGraphEdge_GetTarget_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphEdge_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphEdge_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphEdge.vtkGraphEdge_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphEdge_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphEdge NewInstance()
		{
			vtkGraphEdge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphEdge_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphEdge SafeDownCast(vtkObjectBase o)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphEdge.vtkGraphEdge_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphEdge = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphEdge.Register(null);
				}
			}
			return vtkGraphEdge;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraphEdge_SetId_09(HandleRef pThis, long _arg);

		public virtual void SetId(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetId_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraphEdge_SetSource_10(HandleRef pThis, long _arg);

		public virtual void SetSource(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetSource_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraphEdge_SetTarget_11(HandleRef pThis, long _arg);

		public virtual void SetTarget(long _arg)
		{
			vtkGraphEdge.vtkGraphEdge_SetTarget_11(base.GetCppThis(), _arg);
		}
	}
}
