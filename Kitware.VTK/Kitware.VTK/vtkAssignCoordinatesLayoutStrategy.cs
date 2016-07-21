using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssignCoordinatesLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinatesLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkAssignCoordinatesLayoutStrategy()
		{
			vtkAssignCoordinatesLayoutStrategy.MRClassNameKey = "class vtkAssignCoordinatesLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignCoordinatesLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinatesLayoutStrategy"));
		}

		public vtkAssignCoordinatesLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignCoordinatesLayoutStrategy New()
		{
			vtkAssignCoordinatesLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssignCoordinatesLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_01(HandleRef pThis);

		public virtual string GetXCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetXCoordArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_02(HandleRef pThis);

		public virtual string GetYCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetYCoordArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_03(HandleRef pThis);

		public virtual string GetZCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_GetZCoordArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAssignCoordinatesLayoutStrategy_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAssignCoordinatesLayoutStrategy_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_Layout_06(HandleRef pThis);

		public override void Layout()
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_Layout_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssignCoordinatesLayoutStrategy NewInstance()
		{
			vtkAssignCoordinatesLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinatesLayoutStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignCoordinatesLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAssignCoordinatesLayoutStrategy vtkAssignCoordinatesLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignCoordinatesLayoutStrategy = (vtkAssignCoordinatesLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignCoordinatesLayoutStrategy.Register(null);
				}
			}
			return vtkAssignCoordinatesLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_10(HandleRef pThis, string name);

		public virtual void SetXCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetXCoordArrayName_10(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_11(HandleRef pThis, string name);

		public virtual void SetYCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetYCoordArrayName_11(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_12(HandleRef pThis, string name);

		public virtual void SetZCoordArrayName(string name)
		{
			vtkAssignCoordinatesLayoutStrategy.vtkAssignCoordinatesLayoutStrategy_SetZCoordArrayName_12(base.GetCppThis(), name);
		}
	}
}
