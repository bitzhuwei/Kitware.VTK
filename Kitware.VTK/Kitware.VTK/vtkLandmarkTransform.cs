using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLandmarkTransform : vtkLinearTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLandmarkTransform";

		public new static readonly string MRClassNameKey;

		static vtkLandmarkTransform()
		{
			vtkLandmarkTransform.MRClassNameKey = "class vtkLandmarkTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLandmarkTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLandmarkTransform"));
		}

		public vtkLandmarkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLandmarkTransform New()
		{
			vtkLandmarkTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLandmarkTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLandmarkTransform.vtkLandmarkTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkLandmarkTransform_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLandmarkTransform_GetMode_02(HandleRef pThis);

		public virtual int GetMode()
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_GetMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_GetModeAsString_03(HandleRef pThis);

		public string GetModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkLandmarkTransform.vtkLandmarkTransform_GetModeAsString_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_GetSourceLandmarks_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetSourceLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_GetSourceLandmarks_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_GetTargetLandmarks_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetTargetLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_GetTargetLandmarks_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_Inverse_06(HandleRef pThis);

		public override void Inverse()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_Inverse_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLandmarkTransform_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLandmarkTransform_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLandmarkTransform.vtkLandmarkTransform_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_MakeTransform_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLandmarkTransform NewInstance()
		{
			vtkLandmarkTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLandmarkTransform_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLandmarkTransform SafeDownCast(vtkObjectBase o)
		{
			vtkLandmarkTransform vtkLandmarkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLandmarkTransform.vtkLandmarkTransform_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLandmarkTransform = (vtkLandmarkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLandmarkTransform.Register(null);
				}
			}
			return vtkLandmarkTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetMode_13(HandleRef pThis, int _arg);

		public virtual void SetMode(int _arg)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetMode_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetModeToAffine_14(HandleRef pThis);

		public void SetModeToAffine()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToAffine_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetModeToRigidBody_15(HandleRef pThis);

		public void SetModeToRigidBody()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToRigidBody_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetModeToSimilarity_16(HandleRef pThis);

		public void SetModeToSimilarity()
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetModeToSimilarity_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetSourceLandmarks_17(HandleRef pThis, HandleRef points);

		public void SetSourceLandmarks(vtkPoints points)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetSourceLandmarks_17(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLandmarkTransform_SetTargetLandmarks_18(HandleRef pThis, HandleRef points);

		public void SetTargetLandmarks(vtkPoints points)
		{
			vtkLandmarkTransform.vtkLandmarkTransform_SetTargetLandmarks_18(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}
	}
}
