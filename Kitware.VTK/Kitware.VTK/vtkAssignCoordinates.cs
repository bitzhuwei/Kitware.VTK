using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssignCoordinates : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignCoordinates";

		public new static readonly string MRClassNameKey;

		static vtkAssignCoordinates()
		{
			vtkAssignCoordinates.MRClassNameKey = "class vtkAssignCoordinates";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignCoordinates"));
		}

		public vtkAssignCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignCoordinates New()
		{
			vtkAssignCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssignCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssignCoordinates.vtkAssignCoordinates_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_GetXCoordArrayName_01(HandleRef pThis);

		public virtual string GetXCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetXCoordArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_GetYCoordArrayName_02(HandleRef pThis);

		public virtual string GetYCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetYCoordArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_GetZCoordArrayName_03(HandleRef pThis);

		public virtual string GetZCoordArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAssignCoordinates.vtkAssignCoordinates_GetZCoordArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAssignCoordinates_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAssignCoordinates_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssignCoordinates.vtkAssignCoordinates_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssignCoordinates NewInstance()
		{
			vtkAssignCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignCoordinates_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkAssignCoordinates vtkAssignCoordinates = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignCoordinates.vtkAssignCoordinates_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignCoordinates = (vtkAssignCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignCoordinates.Register(null);
				}
			}
			return vtkAssignCoordinates;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinates_SetJitter_09(HandleRef pThis, byte _arg);

		public virtual void SetJitter(bool _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetJitter_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinates_SetXCoordArrayName_10(HandleRef pThis, string _arg);

		public virtual void SetXCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetXCoordArrayName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinates_SetYCoordArrayName_11(HandleRef pThis, string _arg);

		public virtual void SetYCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetYCoordArrayName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAssignCoordinates_SetZCoordArrayName_12(HandleRef pThis, string _arg);

		public virtual void SetZCoordArrayName(string _arg)
		{
			vtkAssignCoordinates.vtkAssignCoordinates_SetZCoordArrayName_12(base.GetCppThis(), _arg);
		}
	}
}
