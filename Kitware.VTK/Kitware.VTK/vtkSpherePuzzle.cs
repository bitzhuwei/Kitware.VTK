using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSpherePuzzle : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzle";

		public new static readonly string MRClassNameKey;

		static vtkSpherePuzzle()
		{
			vtkSpherePuzzle.MRClassNameKey = "class vtkSpherePuzzle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpherePuzzle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzle"));
		}

		public vtkSpherePuzzle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpherePuzzle New()
		{
			vtkSpherePuzzle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSpherePuzzle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSpherePuzzle.vtkSpherePuzzle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzle_GetState_01(HandleRef pThis);

		public IntPtr GetState()
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_GetState_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpherePuzzle_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpherePuzzle_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzle_MoveHorizontal_04(HandleRef pThis, int section, int percentage, int rightFlag);

		public void MoveHorizontal(int section, int percentage, int rightFlag)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MoveHorizontal_04(base.GetCppThis(), section, percentage, rightFlag);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzle_MovePoint_05(HandleRef pThis, int percentage);

		public void MovePoint(int percentage)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MovePoint_05(base.GetCppThis(), percentage);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzle_MoveVertical_06(HandleRef pThis, int section, int percentage, int rightFlag);

		public void MoveVertical(int section, int percentage, int rightFlag)
		{
			vtkSpherePuzzle.vtkSpherePuzzle_MoveVertical_06(base.GetCppThis(), section, percentage, rightFlag);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzle_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpherePuzzle NewInstance()
		{
			vtkSpherePuzzle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzle_Reset_09(HandleRef pThis);

		public void Reset()
		{
			vtkSpherePuzzle.vtkSpherePuzzle_Reset_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzle_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpherePuzzle SafeDownCast(vtkObjectBase o)
		{
			vtkSpherePuzzle vtkSpherePuzzle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzle.vtkSpherePuzzle_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpherePuzzle = (vtkSpherePuzzle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpherePuzzle.Register(null);
				}
			}
			return vtkSpherePuzzle;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpherePuzzle_SetPoint_11(HandleRef pThis, double x, double y, double z);

		public int SetPoint(double x, double y, double z)
		{
			return vtkSpherePuzzle.vtkSpherePuzzle_SetPoint_11(base.GetCppThis(), x, y, z);
		}
	}
}
